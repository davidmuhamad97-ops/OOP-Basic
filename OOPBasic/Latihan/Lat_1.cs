using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic.Latihan
{
    public class Lat_1
    {
        public static void main()
        {
            TemperatureSensor sensor = new TemperatureSensor();

            sensor.addReading(25.5);
            sensor.addReading(30.2);
            sensor.addReading(-60); // Invalid reading, will throw an exception
            sensor.addReading(200); // Invalid reading, will throw an exception
            sensor.addReading(15.8);

            Console.WriteLine("Average Temperature: " + sensor.getAverage());
            Console.WriteLine("Total Readings: " + sensor.getReadingCount());

        }
    }

    class TemperatureSensor
    {
        private double temperature;
        private int readingCount;
        private List<double> readings;

        public TemperatureSensor()
        {
            this.temperature = 0;
            this.readingCount = 0;
            this.readings = new List<double>();
        }
        public void addReading(double temperature)
        {
            try
            {

                if (temperature >= -50 && temperature <= 150.0)
                {
                    this.temperature = temperature;
                    this.readings.Add(temperature);

                    this.readingCount++;
                }
                else
                {
                    throw new ArgumentException("Temperature must be between -50 and 150 degrees Celsius.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public double getAverage() 
        {
            if (temperature == 0)
            {
                throw new InvalidOperationException("No temperature readings available.");
            }

            double average = temperature; // In a real implementation, you would calculate the average of multiple readings.
            return average;
        }

        public double getReadingCount()
        {
           return this.readingCount;
        }

        public List<double> getReadings()
        {
            return this.readings;
        } 

    }
}
