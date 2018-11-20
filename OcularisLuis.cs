// <auto-generated>
// Code generated by LUISGen 0.1.json -cs Luis.OcularisLuis -o .
// Tool github: https://github.com/microsoft/botbuilder-tools
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>
using Newtonsoft.Json;
using System.Collections.Generic;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.AI.Luis;
namespace Luis
{
    public class OcularisLuis: IRecognizerConvert
    {
        public string Text;
        public string AlteredText;
        public enum Intent {
            Calendar_Add, 
            Calendar_CheckAvailability, 
            Calendar_Delete, 
            Calendar_Edit, 
            Calendar_Find, 
            Camera_CapturePhoto, 
            Camera_CaptureScreenshot, 
            Camera_CaptureSelfie, 
            Camera_CaptureVideo, 
            Camera_StartBroadcasting, 
            Camera_StopBroadcasting, 
            Camera_StopVideoRecording, 
            Communication_AddContact, 
            Communication_AddMore, 
            Communication_Answer, 
            Communication_AssignContactNickname, 
            Communication_CallVoiceMail, 
            Communication_CheckIMStatus, 
            Communication_Confirm, 
            Communication_Dial, 
            Communication_FindContact, 
            Communication_FindSpeedDial, 
            Communication_GetForwardingsStatus, 
            Communication_GoBack, 
            Communication_Ignore, 
            Communication_IgnoreWithMessage, 
            Communication_PressKey, 
            Communication_ReadAloud, 
            Communication_Redial, 
            Communication_Reject, 
            Communication_SendEmail, 
            Communication_SendMessage, 
            Communication_SetSpeedDial, 
            Communication_ShowNext, 
            Communication_ShowPrevious, 
            Communication_StartOver, 
            Communication_TurnForwardingOff, 
            Communication_TurnForwardingOn, 
            Communication_TurnSpeakerOff, 
            Communication_TurnSpeakerOn, 
            Events_Book, 
            None, 
            Note_AddToNote, 
            Note_CheckOffItem, 
            Note_Clear, 
            Note_Confirm, 
            Note_Create, 
            Note_Delete, 
            Note_DeleteNoteItem, 
            Note_ReadAloud, 
            Note_ShowNext, 
            Places_AddFavoritePlace, 
            Places_CheckAccident, 
            Places_CheckAreaTraffic, 
            Places_CheckIntoPlace, 
            Places_CheckRouteTraffic, 
            Places_Confirm, 
            Places_Exit, 
            Places_FindPlace, 
            Places_GetAddress, 
            Places_GetDistance, 
            Places_GetHours, 
            Places_GetMenu, 
            Places_GetPhoneNumber, 
            Places_GetPriceRange, 
            Places_GetReviews, 
            Places_GetRoute, 
            Places_GetStarRating, 
            Places_GetTransportationSchedule, 
            Places_GetTravelTime, 
            Places_MakeCall, 
            Places_MakeReservation, 
            Places_MapQuestions, 
            Places_Rating, 
            Places_ReadAloud, 
            Places_SelectItem, 
            Places_ShowMap, 
            Places_ShowNext, 
            Places_ShowPrevious, 
            Places_StartOver, 
            Places_TakesReservations, 
            Reminder_Change, 
            Reminder_Create, 
            Reminder_Delete, 
            Reminder_Find, 
            Translate_Translate, 
            Utilities_Cancel, 
            Utilities_Confirm, 
            Utilities_FinishTask, 
            Utilities_GoBack, 
            Utilities_Help, 
            Utilities_Repeat, 
            Utilities_ShowNext, 
            Utilities_ShowPrevious, 
            Utilities_StartOver, 
            Utilities_Stop, 
            Vision_Describe, 
            Weather_GetCondition, 
            Weather_GetForecast, 
            Web_Navigate
        };
        public Dictionary<Intent, IntentScore> Intents;

        public class _Entities
        {
            // Simple entities
            public string[] Calendar_Location;
            public string[] Calendar_Subject;
            public string[] Camera_AppName;
            public string[] Communication_AudioDeviceType;
            public string[] Communication_Category;
            public string[] Communication_ContactAttribute;
            public string[] Communication_ContactName;
            public string[] Communication_EmailSubject;
            public string[] Communication_Line;
            public string[] Communication_Message;
            public string[] Communication_MessageType;
            public string[] Communication_OrderReference;
            public string[] Communication_SenderName;
            public string[] Events_Address;
            public string[] Events_Name;
            public string[] Events_PlaceName;
            public string[] Events_PlaceType;
            public string[] Events_Type;
            public string[] Note_AppName;
            public string[] Note_ContactName;
            public string[] Note_DataSource;
            public string[] Note_DataType;
            public string[] Note_Text;
            public string[] Note_Title;
            public string[] Places_AbsoluteLocation;
            public string[] Places_Amenities;
            public string[] Places_Atmosphere;
            public string[] Places_Cuisine;
            public string[] Places_DestinationAddress;
            public string[] Places_DestinationPlaceName;
            public string[] Places_DestinationPlaceType;
            public string[] Places_Distance;
            public string[] Places_MealType;
            public string[] Places_OpenStatus;
            public string[] Places_PlaceName;
            public string[] Places_PlaceType;
            public string[] Places_PreferredRoute;
            public string[] Places_Product;
            public string[] Places_PublicTransportationRoute;
            public string[] Places_Rating;
            public string[] Places_RouteAvoidanceCriteria;
            public string[] Places_ServiceProvided;
            public string[] Places_TransportationCompany;
            public string[] Places_TransportationType;
            public string[] Reminder_Text;
            public string[] Translate_TargetLanguage;
            public string[] Translate_Text;
            public string[] Weather_Location;

            // Instance
            public class _Instance
            {
                public InstanceData[] Calendar_Location;
                public InstanceData[] Calendar_Subject;
                public InstanceData[] Camera_AppName;
                public InstanceData[] Communication_AudioDeviceType;
                public InstanceData[] Communication_Category;
                public InstanceData[] Communication_ContactAttribute;
                public InstanceData[] Communication_ContactName;
                public InstanceData[] Communication_EmailSubject;
                public InstanceData[] Communication_Line;
                public InstanceData[] Communication_Message;
                public InstanceData[] Communication_MessageType;
                public InstanceData[] Communication_OrderReference;
                public InstanceData[] Communication_SenderName;
                public InstanceData[] Events_Address;
                public InstanceData[] Events_Name;
                public InstanceData[] Events_PlaceName;
                public InstanceData[] Events_PlaceType;
                public InstanceData[] Events_Type;
                public InstanceData[] Note_AppName;
                public InstanceData[] Note_ContactName;
                public InstanceData[] Note_DataSource;
                public InstanceData[] Note_DataType;
                public InstanceData[] Note_Text;
                public InstanceData[] Note_Title;
                public InstanceData[] Places_AbsoluteLocation;
                public InstanceData[] Places_Amenities;
                public InstanceData[] Places_Atmosphere;
                public InstanceData[] Places_Cuisine;
                public InstanceData[] Places_DestinationAddress;
                public InstanceData[] Places_DestinationPlaceName;
                public InstanceData[] Places_DestinationPlaceType;
                public InstanceData[] Places_Distance;
                public InstanceData[] Places_MealType;
                public InstanceData[] Places_OpenStatus;
                public InstanceData[] Places_PlaceName;
                public InstanceData[] Places_PlaceType;
                public InstanceData[] Places_PreferredRoute;
                public InstanceData[] Places_Product;
                public InstanceData[] Places_PublicTransportationRoute;
                public InstanceData[] Places_Rating;
                public InstanceData[] Places_RouteAvoidanceCriteria;
                public InstanceData[] Places_ServiceProvided;
                public InstanceData[] Places_TransportationCompany;
                public InstanceData[] Places_TransportationType;
                public InstanceData[] Reminder_Text;
                public InstanceData[] Translate_TargetLanguage;
                public InstanceData[] Translate_Text;
                public InstanceData[] Weather_Location;
            }
            [JsonProperty("$instance")]
            public _Instance _instance;
        }
        public _Entities Entities;

        [JsonExtensionData(ReadData = true, WriteData = true)]
        public IDictionary<string, object> Properties {get; set; }

        public void Convert(dynamic result)
        {
            var app = JsonConvert.DeserializeObject<OcularisLuis>(JsonConvert.SerializeObject(result));
            Text = app.Text;
            AlteredText = app.AlteredText;
            Intents = app.Intents;
            Entities = app.Entities;
            Properties = app.Properties;
        }

        public (Intent intent, double score) TopIntent()
        {
            Intent maxIntent = Intent.None;
            var max = 0.0;
            foreach (var entry in Intents)
            {
                if (entry.Value.Score > max)
                {
                    maxIntent = entry.Key;
                    max = entry.Value.Score.Value;
                }
            }
            return (maxIntent, max);
        }
    }
}
