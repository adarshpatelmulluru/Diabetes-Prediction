using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiabetesPredictionWinForms;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace DiabetesPredictionWinForms
{
    class DiabetesModel
    {
        public static ITransformer TrainModel(List<DiabetesData> data)
        {
            var mlContext = new MLContext();

            var dataView = mlContext.Data.LoadFromEnumerable(data);

            var pipeline = mlContext.Transforms.Conversion.ConvertType(outputColumnName: nameof(DiabetesData.Pregnancies), inputColumnName: nameof(DiabetesData.Pregnancies), outputKind: DataKind.Single)
                .Append(mlContext.Transforms.Conversion.ConvertType(outputColumnName: nameof(DiabetesData.Glucose), inputColumnName: nameof(DiabetesData.Glucose), outputKind: DataKind.Single))
                .Append(mlContext.Transforms.Conversion.ConvertType(outputColumnName: nameof(DiabetesData.BloodPressure), inputColumnName: nameof(DiabetesData.BloodPressure), outputKind: DataKind.Single))
                .Append(mlContext.Transforms.Conversion.ConvertType(outputColumnName: nameof(DiabetesData.SkinThickness), inputColumnName: nameof(DiabetesData.SkinThickness), outputKind: DataKind.Single))
                .Append(mlContext.Transforms.Conversion.ConvertType(outputColumnName: nameof(DiabetesData.Insulin), inputColumnName: nameof(DiabetesData.Insulin), outputKind: DataKind.Single))
                .Append(mlContext.Transforms.Conversion.ConvertType(outputColumnName: nameof(DiabetesData.Age), inputColumnName: nameof(DiabetesData.Age), outputKind: DataKind.Single))
                .Append(mlContext.Transforms.Concatenate("Features",
                    nameof(DiabetesData.Pregnancies),
                    nameof(DiabetesData.Glucose),
                    nameof(DiabetesData.BloodPressure),
                    nameof(DiabetesData.SkinThickness),
                    nameof(DiabetesData.Insulin),
                    nameof(DiabetesData.BMI),
                    nameof(DiabetesData.DiabetesPedigreeFunction),
                    nameof(DiabetesData.Age)))
                .Append(mlContext.BinaryClassification.Trainers.LbfgsLogisticRegression(labelColumnName: nameof(DiabetesData.Outcome), featureColumnName: "Features"));

            return pipeline.Fit(dataView);
        }
    }
}
