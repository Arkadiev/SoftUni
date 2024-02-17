using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharkTaxonomy
{
    public class Classifier
    {
        public Classifier(int capacity)
        {
            Capacity = capacity;
            Species = new List<Shark>();
        }

        public int Capacity { get; set; }

        public List<Shark> Species { get; set; }

        public int GetCount { get => Species.Count; }

        public void AddShark(Shark shark)
        {
            if (Species.Count < Capacity)
            {
                if (!Species.Contains(shark))
                {
                    Species.Add(shark);
                }
            }
        }

        public bool RemoveShark(string kind)
        {
            Shark shark = Species.Find(s => s.Kind == kind);

            if (shark == null)
            {
                return false;
            }

            return Species.Remove(shark);
        }

        public string GetLargestShark()
        {
            return Species.MaxBy(s => s.Length).ToString();
        }

        public double GetAverageLength()
        {
            double average = 0;

            if (Species.Count > 0)
            {
                foreach (Shark shark in Species)
                {
                    average += shark.Length;
                }

                return average / Species.Count;
            }
            else
            {
                return default;
            }
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Species.Count} sharks classified:");
            
            foreach (Shark shark in Species)
            {
                sb.AppendLine(shark.ToString().TrimEnd());
            }

            return sb.ToString().TrimEnd();
        }
    }
}