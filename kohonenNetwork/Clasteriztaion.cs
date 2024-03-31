﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kohonenNetwork
{
    internal class Clasteriztaion
    {
        private List<Neuron> _neurons = new List<Neuron>();
        private double[] _input;
        private Dictionary<int, string> _output = new Dictionary<int, string>();
        public Clasteriztaion(int inputSize, int numClusters)
        {
            _input = new double[inputSize];
            for (int i = 0; i < numClusters; i++)
            {
                _neurons.Add(new Neuron(inputSize));
            }
        }

        public Dictionary<int, string> getOutput()
        {
            return _output;
        }

        public void SelfOrganizingMaps(double delta, double learningSpeed, string filePath)
        {
            double[][] dataset = ReadDataTxt(filePath);

            while (learningSpeed > 0)
            {
                for (int line = 0; line < dataset.Length; line++)
                {
                    _input = dataset[line];
                    int indexMin = FindClosestCluster();
                    for (int j = 0; j < _neurons[indexMin]._weight.Length; j++)
                    {
                        _neurons[indexMin]._weight[j] += learningSpeed * (_input[j] - _neurons[indexMin]._weight[j]);
                    }
                }
                learningSpeed -= delta;
            }
            for (int line = 0; line < dataset.Length; line++)
            {
                _input = dataset[line];
                int idCluster = FindClosestCluster();
                if (_output.ContainsKey(idCluster))
                {
                    _output[idCluster] += ", " + (line + 1);
                }
                else
                {
                    _output[idCluster] = "Включает в себя образцы с номерами: " + (line + 1);
                }
            }
            int a = 0;
        }
        

        private int FindClosestCluster()
        {
            _neurons[0].SetInput(_input);
            double min_dist = _neurons[0].Distance();
            int index = 0;
            for (int i = 1; i < _neurons.Count; i++)
            {
                _neurons[i].SetInput(_input);
                if (_neurons[i].Distance() < min_dist)
                {
                    index = i;
                    min_dist = _neurons[i].Distance();
                }
            }
            return index;
        }


        private double[][] ReadDataTxt(string filePath)
        {
            double[][] dataset = new double[System.IO.File.ReadAllLines(filePath).Length][];
            using (StreamReader sr = new StreamReader(filePath))
            {
                string? line;
                int line_count = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] input_string = line.Split(';');
                    double[] input_double = new double[input_string.Length];
                    for (int j = 0; j < _input.Length; j++)
                        input_double[j] = Convert.ToDouble(input_string[j]);
                    dataset[line_count] = input_double;
                    line_count++;
                }
            }
            NormalizeData(dataset);
            return dataset;
        }

        private void NormalizeData(double[][] dataset)
        {
            double min;
            double max;
            for (int col = 0; col < dataset[0].Length; col++)
            {

                max = dataset[0][col];
                min = dataset[0][col];
                for (int line = 1; line < dataset.Length; line++) 
                {
                    if (dataset[line][col] < min) min = dataset[line][col];
                    if (dataset[line][col] > max) max = dataset[line][col];
                }
                for (int line = 0; line < dataset.Length; line++) 
                {
                    dataset[line][col] = (-1) + (dataset[line][col] - min) / (max - min) * 2;
                }
            }
        }


        
    }
}