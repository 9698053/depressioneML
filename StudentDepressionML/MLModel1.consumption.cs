﻿// This file was auto-generated by ML.NET Model Builder.
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace StudentDepressionML
{
    public partial class MLModel1
    {
        /// <summary>
        /// model input class for MLModel1.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [LoadColumn(0)]
            [ColumnName(@"id")]
            public float Id { get; set; }

            [LoadColumn(1)]
            [ColumnName(@"Gender")]
            public string Gender { get; set; }

            [LoadColumn(2)]
            [ColumnName(@"Age")]
            public float Age { get; set; }

            [LoadColumn(3)]
            [ColumnName(@"City")]
            public string City { get; set; }

            [LoadColumn(4)]
            [ColumnName(@"Profession")]
            public string Profession { get; set; }

            [LoadColumn(5)]
            [ColumnName(@"Academic Pressure")]
            public float Academic_Pressure { get; set; }

            [LoadColumn(6)]
            [ColumnName(@"Work Pressure")]
            public float Work_Pressure { get; set; }

            [LoadColumn(7)]
            [ColumnName(@"CGPA")]
            public float CGPA { get; set; }

            [LoadColumn(8)]
            [ColumnName(@"Study Satisfaction")]
            public float Study_Satisfaction { get; set; }

            [LoadColumn(9)]
            [ColumnName(@"Job Satisfaction")]
            public float Job_Satisfaction { get; set; }

            [LoadColumn(10)]
            [ColumnName(@"Sleep Duration")]
            public string Sleep_Duration { get; set; }

            [LoadColumn(11)]
            [ColumnName(@"Dietary Habits")]
            public string Dietary_Habits { get; set; }

            [LoadColumn(12)]
            [ColumnName(@"Degree")]
            public string Degree { get; set; }

            [LoadColumn(13)]
            [ColumnName(@"Have you ever had suicidal thoughts ?")]
            public bool Have_you_ever_had_suicidal_thoughts__ { get; set; }

            [LoadColumn(14)]
            [ColumnName(@"Work/Study Hours")]
            public float Work_Study_Hours { get; set; }

            [LoadColumn(15)]
            [ColumnName(@"Financial Stress")]
            public float Financial_Stress { get; set; }

            [LoadColumn(16)]
            [ColumnName(@"Family History of Mental Illness")]
            public bool Family_History_of_Mental_Illness { get; set; }

            [LoadColumn(17)]
            [ColumnName(@"Depression")]
            public float Depression { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for MLModel1.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"id")]
            public float Id { get; set; }

            [ColumnName(@"Gender")]
            public float[] Gender { get; set; }

            [ColumnName(@"Age")]
            public float Age { get; set; }

            [ColumnName(@"City")]
            public float[] City { get; set; }

            [ColumnName(@"Profession")]
            public float[] Profession { get; set; }

            [ColumnName(@"Academic Pressure")]
            public float Academic_Pressure { get; set; }

            [ColumnName(@"Work Pressure")]
            public float Work_Pressure { get; set; }

            [ColumnName(@"CGPA")]
            public float CGPA { get; set; }

            [ColumnName(@"Study Satisfaction")]
            public float Study_Satisfaction { get; set; }

            [ColumnName(@"Job Satisfaction")]
            public float Job_Satisfaction { get; set; }

            [ColumnName(@"Sleep Duration")]
            public float[] Sleep_Duration { get; set; }

            [ColumnName(@"Dietary Habits")]
            public float[] Dietary_Habits { get; set; }

            [ColumnName(@"Degree")]
            public float[] Degree { get; set; }

            [ColumnName(@"Have you ever had suicidal thoughts ?")]
            public float[] Have_you_ever_had_suicidal_thoughts__ { get; set; }

            [ColumnName(@"Work/Study Hours")]
            public float Work_Study_Hours { get; set; }

            [ColumnName(@"Financial Stress")]
            public float Financial_Stress { get; set; }

            [ColumnName(@"Family History of Mental Illness")]
            public float[] Family_History_of_Mental_Illness { get; set; }

            [ColumnName(@"Depression")]
            public uint Depression { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"PredictedLabel")]
            public float PredictedLabel { get; set; }

            [ColumnName(@"Score")]
            public float[] Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("MLModel1.mlnet");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);


        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }

        /// <summary>
        /// Use this method to predict scores for all possible labels.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static IOrderedEnumerable<KeyValuePair<string, float>> PredictAllLabels(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            var result = predEngine.Predict(input);
            return GetSortedScoresWithLabels(result);
        }

        /// <summary>
        /// Map the unlabeled result score array to the predicted label names.
        /// </summary>
        /// <param name="result">Prediction to get the labeled scores from.</param>
        /// <returns>Ordered list of label and score.</returns>
        /// <exception cref="Exception"></exception>
        public static IOrderedEnumerable<KeyValuePair<string, float>> GetSortedScoresWithLabels(ModelOutput result)
        {
            var unlabeledScores = result.Score;
            var labelNames = GetLabels(result);

            Dictionary<string, float> labledScores = new Dictionary<string, float>();
            for (int i = 0; i < labelNames.Count(); i++)
            {
                // Map the names to the predicted result score array
                var labelName = labelNames.ElementAt(i);
                labledScores.Add(labelName.ToString(), unlabeledScores[i]);
            }

            return labledScores.OrderByDescending(c => c.Value);
        }

        /// <summary>
        /// Get the ordered label names.
        /// </summary>
        /// <param name="result">Predicted result to get the labels from.</param>
        /// <returns>List of labels.</returns>
        /// <exception cref="Exception"></exception>
        private static IEnumerable<string> GetLabels(ModelOutput result)
        {
            var schema = PredictEngine.Value.OutputSchema;

            var labelColumn = schema.GetColumnOrNull("Depression");
            if (labelColumn == null)
            {
                throw new Exception("Depression column not found. Make sure the name searched for matches the name in the schema.");
            }

            // Key values contains an ordered array of the possible labels. This allows us to map the results to the correct label value.
            var keyNames = new VBuffer<float>();
            labelColumn.Value.GetKeyValues(ref keyNames);
            return keyNames.DenseValues().Select(x => x.ToString());
        }

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

    }
}
