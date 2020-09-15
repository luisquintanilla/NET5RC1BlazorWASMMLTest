// This file was auto-generated by ML.NET Model Builder. 

using System;
using MLBlazorApp1ML.Model;

namespace MLBlazorApp1ML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                A = 5.1F,
                B = 3.5F,
                C = 1.4F,
                D = 0.2F,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual E with predicted E from sample data...\n\n");
            Console.WriteLine($"A: {sampleData.A}");
            Console.WriteLine($"B: {sampleData.B}");
            Console.WriteLine($"C: {sampleData.C}");
            Console.WriteLine($"D: {sampleData.D}");
            Console.WriteLine($"\n\nPredicted E value {predictionResult.Prediction} \nPredicted E scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
