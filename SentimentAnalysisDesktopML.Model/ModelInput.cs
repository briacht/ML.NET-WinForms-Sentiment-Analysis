// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace SentimentAnalysisDesktopML.Model
{
    public class ModelInput
    {
        [ColumnName("Comment"), LoadColumn(0)]
        public string Comment { get; set; }


        [ColumnName("Sentiment"), LoadColumn(1)]
        public bool Sentiment { get; set; }


    }
}
