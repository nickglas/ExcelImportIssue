using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using OfficeOpenXml;
using System.Text;
using EPPlusCore.Models.DBF;
using System.Data.SqlClient;
using System.Diagnostics;
using Importexcel.Models;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EPPlusCore.Controllers
{
    [Produces("application/json")]
    public class CustomerController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly DbCustomersContext _db;

        public CustomerController(IHostingEnvironment hostingEnvironment, DbCustomersContext db)
        {
            _hostingEnvironment = hostingEnvironment;
            _db = db;
        }

        [HttpGet]
        [Route("View")]
        public IActionResult Index()
        {
            response model = new response();
            model.answer = "Upload een bestand";
            return View(model);
        }

        [HttpPost]
        public IActionResult Post(List<IFormFile> files)
        {


            long size = files.Sum(f => f.Length);
            var filePath = Path.GetTempFileName();
            var test = Path.GetDirectoryName(filePath) + Path.DirectorySeparatorChar;
            var fileName = Path.GetFileName(filePath);
            var result = Path.ChangeExtension(fileName, ".xlsx");
            

            foreach (var formFile in files)
            {
                if (formFile.Length <= 0)
                {
                    continue;
                }

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    
                    formFile.CopyToAsync(stream);
                    
                }
            }
            FileInfo x = new FileInfo(filePath);
            x.MoveTo(Path.ChangeExtension(filePath, ".xlsx"));
            Debug.Write(filePath);
       
            FileInfo file = new FileInfo(Path.Combine(test, result));

            //DEBUG NAMEN NAAR CONSOLE
            //Debug.WriteLine("\n");
            //Debug.WriteLine("!!!!!!!!!!!!!!!!!!!!!!");
            //Debug.WriteLine(filePath);
            //Debug.WriteLine(test);
            //Debug.WriteLine(result);
            //Debug.WriteLine("!!!!!!!!!!!!!!!!!!!!!! \n\n");

            
                using (ExcelPackage package = new ExcelPackage(file))
                {
                    response model = new response();
                    ExcelWorksheet workSheet = package.Workbook.Worksheets[0];
                    int totalRows = workSheet.Dimension.Rows;

                    //Kijkt of het ease excel template word gebruikt
                    string check = workSheet.Cells[1, 1].Value.ToString();

                    if (check != "ease_import_sheet")
                    {                       
                        model.answer = "De sheet die u heeft geselecteerd is niet geldig.";
                        return View(model);
                    }

                    List<Issue> issuelist = new List<Issue>();
                    List<Data> datas = new List<Data>();

                    SqlConnection connection = new SqlConnection(@"Data Source=BTO;Initial Catalog=CoreDb;Integrated Security=True");
                    connection.Open();
                    Debug.Write(connection.State.ToString());
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Issue", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Data item = new Data();
                        item.Gereed = reader.GetString(0);
                        item.Project_Code = reader.GetString(1);
                        item.Organisatie_Code = reader.GetString(2);
                        item.Input_Bron = reader.GetString(3);
                        item.AardId = reader.GetString(4);
                        item.Categorie = reader.GetString(5);
                        item.Actiehouder = reader.GetString(6);
                        item.Prioriteit = reader.GetString(7);
                        item.Kenmerk = reader.GetString(8);
                        item.Issues = reader.GetString(9);
                        item.Antwoord = reader.GetString(10);
                        item.Opmerking = reader.GetString(11);
                        item.Aangever = reader.GetString(12);
                        item.Man_Uren = reader.GetString(13);
                        item.Datum_Ingedied = reader.GetString(14);
                        item.Datum_Gepland = reader.GetString(15);
                        item.Datum_Gereed = reader.GetString(16);
                        item.Status = reader.GetString(17);


                        datas.Add(item);

                        //PRINT ALLE ENTRIES IN DE DEBUG CONSOLE
                        Debug.WriteLine("\n\n", item.Id);
                        Debug.WriteLine(item.Gereed);
                        Debug.WriteLine(item.Project_Code);
                        Debug.WriteLine(item.Organisatie_Code);
                        Debug.WriteLine(item.Input_Bron);
                        Debug.WriteLine(item.AardId);
                        Debug.WriteLine(item.Categorie);
                        Debug.WriteLine(item.Prioriteit);
                        Debug.WriteLine(item.Kenmerk);
                        Debug.WriteLine(item.Issues);
                        Debug.WriteLine(item.Antwoord);
                        Debug.WriteLine(item.Opmerking);
                        Debug.WriteLine(item.Aangever);
                        Debug.WriteLine(item.Man_Uren);
                        Debug.WriteLine(item.Datum_Ingedied);
                        Debug.WriteLine(item.Datum_Gepland);
                        Debug.WriteLine(item.Datum_Gereed);
                        Debug.WriteLine(item.Status);
                        Debug.Write("\n");

                    }
                    connection.Close();

                int dubbele_data = 0;
                    for (int i = 4; i <= totalRows; i++)
                    {
                        Issue issue = new Issue();
                        
                        issue.Gereed = workSheet.Cells[i, 1].Value.ToString();
                        issue.Project_Code = workSheet.Cells[i, 2].Value.ToString();
                        issue.Organisatie_Code = workSheet.Cells[i, 3].Value.ToString();
                        issue.Input_Bron = workSheet.Cells[i, 4].Value.ToString();
                        issue.AardId = workSheet.Cells[i, 5].Value.ToString();
                        issue.Categorie = workSheet.Cells[i, 6].Value.ToString();
                        issue.Actiehouder = workSheet.Cells[i, 7].Value.ToString();
                        issue.Prioriteit = workSheet.Cells[i, 8].Value.ToString();
                        issue.Kenmerk = workSheet.Cells[i, 9].Value.ToString();
                        issue.Issues = workSheet.Cells[i, 10].Value.ToString();
                        issue.Antwoord = workSheet.Cells[i, 11].Value.ToString();
                        issue.Opmerking = workSheet.Cells[i, 12].Value.ToString();
                        issue.Aangever = workSheet.Cells[i, 13].Value.ToString();
                        issue.ManUren = workSheet.Cells[i, 14].Value.ToString();
                        issue.Datum_Ingediend = workSheet.Cells[i, 15].Value.ToString();
                        issue.Datum_Gepland = workSheet.Cells[i, 16].Value.ToString();
                        issue.Datum_Gereed = workSheet.Cells[i, 17].Value.ToString();
                        issue.Status = workSheet.Cells[i, 18].Value.ToString();



                        foreach (var item in datas)
                        {
                            if (issue.Project_Code == item.Project_Code)
                            {
                                // Response.WriteAsync("<script>alert('DUBBELE DATA GEVONDEN!');</script>");
                                issue.Project_Code = null;
                                dubbele_data += 1;
                            }

                        }
                        if (issue.Project_Code != null)
                        {
                        Debug.WriteLine("\n\n ISSUE Lijnnummer " + i + " Added \n ");
                        issuelist.Add(issue);
                        }
                    
                            _db.Issue.AddRange(issuelist);
                    }

                if (dubbele_data != 0)
                {
                    model.answer = "Er is/zijn " + dubbele_data + " dubbele rijen gevonden. De rest is toegevoegd.";
                }
                else
                {
                    model.answer = "Succesvol toegevoegd";
                }
                _db.SaveChanges();
                return View(model);
                }
            
            
               
            
            
            
        }

        [HttpGet]
        [Route("ExportCustomer")]
        public string ExportCustomer()
        {
            string rootFolder = _hostingEnvironment.WebRootPath;
            string fileName = @"ExportCustomers.xlsx";

            FileInfo file = new FileInfo(Path.Combine(rootFolder, fileName));

            using (ExcelPackage package = new ExcelPackage(file))
            {
                IList<Issue> issuelist = _db.Issue.ToList();

                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Issue");
                int totalRows = issuelist.Count();

                worksheet.Cells[1, 1].Value = "ease_import_sheet";
                
                int i = 0;
                for (int row = 3; row <= totalRows + 2; row++)
                {
                    worksheet.Cells[row, 1].Value = issuelist[i].Gereed;
                    worksheet.Cells[row, 2].Value = issuelist[i].Project_Code;
                    worksheet.Cells[row, 3].Value = issuelist[i].Organisatie_Code;
                    worksheet.Cells[row, 4].Value = issuelist[i].Input_Bron;
                    worksheet.Cells[row, 5].Value = issuelist[i].AardId;
                    worksheet.Cells[row, 6].Value = issuelist[i].Issues;
                    worksheet.Cells[row, 7].Value = issuelist[i].Categorie;
                    worksheet.Cells[row, 8].Value = issuelist[i].Actiehouder;
                    worksheet.Cells[row, 9].Value = issuelist[i].Prioriteit;
                    worksheet.Cells[row, 10].Value = issuelist[i].Kenmerk;
                    worksheet.Cells[row, 11].Value = issuelist[i].Issues;
                    worksheet.Cells[row, 12].Value = issuelist[i].Antwoord;
                    worksheet.Cells[row, 13].Value = issuelist[i].Opmerking;
                    worksheet.Cells[row, 14].Value = issuelist[i].Aangever;
                    worksheet.Cells[row, 15].Value = issuelist[i].ManUren;
                    worksheet.Cells[row, 16].Value = issuelist[i].Datum_Ingediend;
                    worksheet.Cells[row, 17].Value = issuelist[i].Datum_Gepland;
                    worksheet.Cells[row, 18].Value = issuelist[i].Datum_Gereed;
                    worksheet.Cells[row, 19].Value = issuelist[i].Status;
                    i++;
                    worksheet.Cells["A1:Z40"].AutoFitColumns();
                }
                package.Save();
            }
            return "Customer list has been exported successfully";
        }

        [HttpGet]
        [Route("tabel")]
        public IActionResult tabel()
        {
           string connectionstring = @"Data Source=BTO;Initial Catalog=CoreDb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(@"Data Source=BTO;Initial Catalog=CoreDb;Integrated Security=True");
           string sql = "SELECT * FROM Issue";
            SqlCommand cmd = new SqlCommand(sql, conn);
            var model = new List<Issue>();
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var item = new Issue();
                item.Gereed = reader.GetString(0);
                item.Project_Code = reader.GetString(1);
                item.Organisatie_Code = reader.GetString(2);
                item.Input_Bron = reader.GetString(3);
                item.AardId = reader.GetString(4);
                item.Categorie = reader.GetString(5);
                item.Actiehouder = reader.GetString(6);
                item.Prioriteit = reader.GetString(7);
                item.Kenmerk = reader.GetString(8);
                item.Issues = reader.GetString(9);
                item.Antwoord = reader.GetString(10);
                item.Opmerking = reader.GetString(11);
                item.Aangever = reader.GetString(12);
                item.ManUren = reader.GetString(13);
                item.Datum_Ingediend = reader.GetString(14);
                item.Datum_Gepland = reader.GetString(15);
                item.Datum_Gereed = reader.GetString(16);
                item.Status = reader.GetString(17);
                model.Add(item);
            }
            conn.Close();
            return View(model);
        }
    }
}