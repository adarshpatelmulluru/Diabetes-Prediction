using System;
using System.Windows.Forms;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace DiabetesPredictionWinForms
{
    public partial class MainForm : Form
    {
        private static ITransformer trainedModel;
        private static MLContext mlContext;

        public MainForm()
        {
            InitializeComponent();
            mlContext = new MLContext();
            LoadModel();
        }

        private void LoadModel()
        {
            string modelPath = @"D:\C# projects\DiabetesPrediction\DiabetesPredictionWinForms\DiabetesPredictionWinForms\model.zip"; // Path to the pre-trained model
            trainedModel = mlContext.Model.Load(modelPath, out var modelInputSchema);
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            try
            {
               
                var pregnancies = float.Parse(txtPregnancies.Text);
                var glucose = float.Parse(txtGlucose.Text);
                var bloodPressure = float.Parse(txtBloodPressure.Text);
                var skinThickness = float.Parse(txtSkinThickness.Text);
                var insulin = float.Parse(txtInsulin.Text);
                var bmi = float.Parse(txtBMI.Text);
                var diabetesPedigreeFunction = float.Parse(txtDiabetesPedigreeFunction.Text);
                var age = float.Parse(txtAge.Text);

                
                var inputFeatures = new float[]
                {
                    pregnancies, glucose, bloodPressure, skinThickness, insulin, bmi, diabetesPedigreeFunction, age
                };

               
                var (predictedLabel, probability) = Prediction.MakePrediction(trainedModel, inputFeatures);
                lblResult.Text = $"Prediction: {(predictedLabel ? "Diabetic" : "Non-Diabetic")}\nProbability: {probability:P2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Prediction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
