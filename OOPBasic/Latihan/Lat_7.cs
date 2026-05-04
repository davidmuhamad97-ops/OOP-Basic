using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OOPBasic.Latihan
{
    public class Lat_7
    {
        public static void main()
        {
            DataExporter csv = new CSVEksporter();
            csv.export(new List<string>() { "Messi", "Ronaldo", "Neymar", "Bale"});
            Console.WriteLine(csv.Data);

            JSONExporter json = new JSONExporter();
            json.export(new List<string>());
            Console.WriteLine(json.Data);

        }
    }

    abstract class DataExporter
    {
        public abstract string Data { get; set; }
        public abstract void export(List<string> payload);
        public bool validate(List<string> payload)
        {
           if (payload is null || payload.Count == 0) return false;

            return true;
        }
    }

    class CSVEksporter : DataExporter
    {
        public override string Data {  get; set; }

        public override void export(List<string> payload)
        {
            try
            {
                bool isSuccess = this.validate(payload);

                if (!isSuccess)
                {
                    throw new Exception("Export is failed");
                }

                this.Data = String.Join(",", payload);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.ToString());
            }
        }
    }

    class JSONExporter : DataExporter
    {

        public override string Data { get; set; }
        public override void export(List<string> payload)
        {

            try
            {
                bool isSuccess = this.validate(payload);

                var result = new
                {
                    payload = payload
                };

                if (!isSuccess)
                {
                    throw new Exception("Data is failed");
                }

                this.Data = JsonSerializer.Serialize(result, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
    }
}
