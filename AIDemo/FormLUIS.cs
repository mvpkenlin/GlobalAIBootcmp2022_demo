﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using MetroSet_UI.Forms;
using MetroSet_UI.Controls;

// Import namespaces
using Microsoft.Azure.CognitiveServices.Language.LUIS.Runtime;
using Microsoft.Azure.CognitiveServices.Language.LUIS.Runtime.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AIDemo
{
    public partial class FormLUIS : Form
    {
        private static FormLUIS form;
        private static LUISRuntimeClient luClient;
        private static ApiKeyServiceClientCredentials credentials;

        string predictionEndpoint;
        string predictionKey;
        Guid luAppId;

        private void FormLUIS_Load(object sender, EventArgs e)
        {
            try
            {
                IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
                IConfigurationRoot configuration = builder.Build();
                luAppId = Guid.Parse(configuration["LuAppID"]);
                predictionEndpoint = configuration["LuPredictionEndpoint"];
                predictionKey = configuration["LuPredictionKey"];

                // Create a client for the LU app
                credentials = new Microsoft.Azure.CognitiveServices.Language.LUIS.Runtime.ApiKeyServiceClientCredentials(predictionKey);
                luClient = new LUISRuntimeClient(credentials) { Endpoint = predictionEndpoint };

            }
            catch (Exception ex)
            {
                DisplayError(ex.Message);
            }
        }

        public FormLUIS()
        {
            InitializeComponent();
        }

        private async void msbtnAskTime_Click(object sender, EventArgs e)
        {
            try
            {
                txtTimeAnswer.Text = "";
                string userText = txtAskTime.Text;
                // Call the LU app to get intent and entities
                var slot = "Production";
                var request = new PredictionRequest { Query = userText };
                PredictionResponse predictionResponse = await luClient.Prediction.GetSlotPredictionAsync(luAppId, slot, request);
                txtTimeAnswer.AppendText(JsonConvert.SerializeObject(predictionResponse, Formatting.Indented));
                txtTimeAnswer.AppendText("--------------------\n");
                txtTimeAnswer.AppendText(Environment.NewLine);
                txtTimeAnswer.AppendText(predictionResponse.Query);
                txtTimeAnswer.AppendText(Environment.NewLine);
                var topIntent = predictionResponse.Prediction.TopIntent;
                var entities = predictionResponse.Prediction.Entities;

                // Apply the appropriate action
                switch (topIntent)
                {
                    case "GetTime":
                        var location = "local";
                        // Check for entities
                        if (entities.Count > 0)
                        {
                            // Check for a location entity
                            if (entities.ContainsKey("Location"))
                            {
                                //Get the JSON for the entity
                                var entityJson = JArray.Parse(entities["Location"].ToString());
                                // ML entities are strings, get the first one
                                location = entityJson[0].ToString();
                            }
                        }

                        // Get the time for the specified location
                        var getTimeTask = Task.Run(() => GetTime(location));
                        string timeResponse = await getTimeTask;
                        txtTimeAnswer.AppendText(Environment.NewLine);
                        txtTimeAnswer.AppendText(timeResponse);
                        break;

                    case "GetDay":
                        var date = DateTime.Today.ToShortDateString();
                        // Check for entities
                        if (entities.Count > 0)
                        {
                            // Check for a Date entity
                            if (entities.ContainsKey("Date"))
                            {
                                //Get the JSON for the entity
                                var entityJson = JArray.Parse(entities["Date"].ToString());
                                // Regex entities are strings, get the first one
                                date = entityJson[0].ToString();
                            }
                        }
                        // Get the day for the specified date
                        var getDayTask = Task.Run(() => GetDay(date));
                        string dayResponse = await getDayTask;
                        txtTimeAnswer.AppendText(Environment.NewLine);
                        txtTimeAnswer.AppendText(dayResponse);
                        break;

                    case "GetDate":
                        var day = DateTime.Today.DayOfWeek.ToString();
                        // Check for entities
                        if (entities.Count > 0)
                        {
                            // Check for a Weekday entity
                            if (entities.ContainsKey("Weekday"))
                            {
                                //Get the JSON for the entity
                                var entityJson = JArray.Parse(entities["Weekday"].ToString());
                                // List entities are lists
                                day = entityJson[0][0].ToString();
                            }
                        }
                        // Get the date for the specified day
                        var getDateTask = Task.Run(() => GetDate(day));
                        string dateResponse = await getDateTask;
                        txtTimeAnswer.AppendText(Environment.NewLine);
                        txtTimeAnswer.AppendText(dateResponse);
                        break;

                    default:
                        // Some other intent (for example, "None") was predicted
                        txtTimeAnswer.AppendText("\nTry asking me for the time, the day, or the date.");
                        break;
                }
            }
            catch (Exception ex)
            {
                DisplayError(ex.Message);
            }
        }

        static string GetTime(string location)
        {
            var timeString = "";
            var time = DateTime.Now;

            /* Note: To keep things simple, we'll ignore daylight savings time and support only a few cities.
               In a real app, you'd likely use a web service API (or write  more complex code!)
               Hopefully this simplified example is enough to get the the idea that you
               use LU to determine the intent and entitites, then implement the appropriate logic */

            switch (location.ToLower())
            {
                case "local":
                    timeString = time.Hour.ToString() + ":" + time.Minute.ToString("D2");
                    break;
                case "london":
                    time = DateTime.UtcNow;
                    timeString = time.Hour.ToString() + ":" + time.Minute.ToString("D2");
                    break;
                case "sydney":
                    time = DateTime.UtcNow.AddHours(11);
                    timeString = time.Hour.ToString() + ":" + time.Minute.ToString("D2");
                    break;
                case "new york":
                    time = DateTime.UtcNow.AddHours(-5);
                    timeString = time.Hour.ToString() + ":" + time.Minute.ToString("D2");
                    break;
                case "nairobi":
                    time = DateTime.UtcNow.AddHours(3);
                    timeString = time.Hour.ToString() + ":" + time.Minute.ToString("D2");
                    break;
                case "tokyo":
                    time = DateTime.UtcNow.AddHours(9);
                    timeString = time.Hour.ToString() + ":" + time.Minute.ToString("D2");
                    break;
                case "delhi":
                    time = DateTime.UtcNow.AddHours(5.5);
                    timeString = time.Hour.ToString() + ":" + time.Minute.ToString("D2");
                    break;
                default:
                    timeString = "I don't know what time it is in " + location;
                    break;
            }

            return timeString;
        }

        static string GetDate(string day)
        {
            string date_string = "I can only determine dates for today or named days of the week.";

            // To keep things simple, assume the named day is in the current week (Sunday to Saturday)
            DayOfWeek weekDay;
            if (Enum.TryParse(day, true, out weekDay))
            {
                int weekDayNum = (int)weekDay;
                int todayNum = (int)DateTime.Today.DayOfWeek;
                int offset = weekDayNum - todayNum;
                date_string = DateTime.Today.AddDays(offset).ToShortDateString();
            }
            return date_string;

        }

        static string GetDay(string date)
        {
            // Note: To keep things simple, dates must be entered in US format (MM/DD/YYYY)
            string day_string = "Enter a date in MM/DD/YYYY format.";
            DateTime dateTime;
            if (DateTime.TryParse(date, out dateTime))
            {
                day_string = dateTime.DayOfWeek.ToString();
            }

            return day_string;
        }

        private void DisplayError(string errorMessage)
        {
            MetroSetMessageBox.Show(new FormMessageBox(), errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DisplayInfo(string infoMessage)
        {
            MetroSetMessageBox.Show(new FormMessageBox(), infoMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
