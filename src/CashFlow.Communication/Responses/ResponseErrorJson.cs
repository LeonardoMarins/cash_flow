﻿namespace CashFlow.Communication.Responses
{
    public class ResponseErrorJson
    {
        public List<string> ErrorMessages { get; set; }

        public ResponseErrorJson(List<string> errorMessages) 
        {
            ErrorMessages = errorMessages;
        }

        public ResponseErrorJson(string errorMessages)
        {
            ErrorMessages = new List<string> { errorMessages };
        }

    }
}
