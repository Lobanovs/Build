using Builder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Models
{
    public class Computer
    {
        public CPU Cpu { get; set; }
        public Motherboard Motherboard { get; set; }
        public RAM Ram { get; set; }
        public Storage Storage { get; set; }
        public GPU Gpu { get; set; }

        public override string ToString()
        {
            return $"Computer: \n" +
                   $"CPU: {Cpu}\n" +
                   $"Motherboard: {Motherboard}\n" +
                   $"RAM: {Ram}\n" +
                   $"Storage: {Storage}\n" +
                   $"GPU: {Gpu}";
        }
    }
}
