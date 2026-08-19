using Microsoft.AspNetCore.Hosting;
using PiramalSchoolOfLeadership.Models;
using System.Text.Json;

namespace PiramalSchoolOfLeadership.Helper
{
    public class JsonReaderFromFile
    {
        public static JSONResponse ReadJsonFileToList(string fileName, string wwwRootPath)
        {
            // Combine with the relative path to your JSON file  
            string jsonFilePath = Path.Combine(wwwRootPath, "data", fileName);

            if (!File.Exists(jsonFilePath))
            {
                return null;
            }
            try
            {
                // Read the entire JSON file content as a string asynchronously  
                string jsonString = File.ReadAllText(jsonFilePath);

                // Deserialize the JSON string into a List of MyItem objects  
                //List<JSONModel> items = JsonSerializer.Deserialize<List<JSONModel>>(jsonString);
                JSONResponse blogData = JsonSerializer.Deserialize<JSONResponse>(jsonString);
                return blogData;
            }
            catch (JsonException ex)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

