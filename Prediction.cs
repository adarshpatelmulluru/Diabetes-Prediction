using Microsoft.ML;
using System.Windows.Forms;

namespace DiabetesPredictionWinForms
{
    public static class Prediction
    {
        public static (bool PredictedLabel, float Probability) MakePrediction(ITransformer model, float[] inputFeatures)
        {
            var mlContext = new MLContext();
            var predictionEngine = mlContext.Model.CreatePredictionEngine<DiabetesData, DiabetesPrediction>(model);

            var input = new DiabetesData
            {
                Pregnancies = (int)inputFeatures[0],
                Glucose = (int)inputFeatures[1],
                BloodPressure = (int)inputFeatures[2],
                SkinThickness = (int)inputFeatures[3],
                Insulin = (int)inputFeatures[4],
                BMI = inputFeatures[5],
                DiabetesPedigreeFunction = inputFeatures[6],
                Age = (int)inputFeatures[7]
            };

            var result = predictionEngine.Predict(input);
            return (result.PredictedLabel, result.Probability);
        }
    }

    public class DiabetesPrediction
    {
        public bool PredictedLabel { get; set; }
        public float Probability { get; set; }
        public float Score { get; set; }
    }
}
