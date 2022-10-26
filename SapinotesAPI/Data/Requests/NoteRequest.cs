﻿namespace SapinotesAPI.Data.Requests
{
    public class NoteRequest
    {
        public int userID { get; set; }
        public string username { get; set; }
        public int subjectID { get; set; }
        public string noteName { get; set; }
        public int noteDocID { get; set; }
        public double noteRatingValue { get; set; }
        public int numberOfRatings { get; set; }
    }
}
