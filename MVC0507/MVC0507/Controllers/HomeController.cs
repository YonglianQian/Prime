using MVC0507.Models;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC0507.Controllers
{
    public class HomeController : Controller
    {
        EFDbContext context = new EFDbContext();
        public ViewResult Index()
        {
            List<Product> products = context.Products.ToList();
            return View(products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult epplus()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult ImportContacts()
        {
            try
            {


                if (Request.Files.Count > 0)
                {
                    try
                    {
                        HttpFileCollectionBase files = Request.Files;
                        for (int i = 0; i < files.Count; i++)
                        {
                            HttpPostedFileBase file = files[i];
                            string fileName = file.FileName;
                            string fileContentType = file.ContentType;
                            byte[] fileBytes = new byte[file.ContentLength];
                            var data = file.InputStream.Read(fileBytes, 0, Convert.ToInt32(file.ContentLength));
                            //List<lead> leadsList = new List<lead>();
                            List<ImportExcelViewModel> lstImportExcel = new List<ImportExcelViewModel>();
                            List<ImportExcelViewModel> errorLstImportExcel = new List<ImportExcelViewModel>();

                            using (var package = new ExcelPackage(file.InputStream))
                            {
                                var currentSheet = package.Workbook.Worksheets;
                                var workSheet = currentSheet.First();
                                var noOfCol = workSheet.Dimension.End.Column;
                                var noOfRow = workSheet.Dimension.End.Row;

                                //first row is titles
                                for (int rowIterator = 2; rowIterator <= noOfRow; rowIterator++)
                                {
                                    /********************************Validtae*************************/
                                    var importExcelRow = new ImportExcelViewModel
                                    {


                                        email = workSheet.Cells[rowIterator, 3].Value.ToString()

                                    };
                                    lstImportExcel.Add(importExcelRow);
                                    /*****************************validate*****************************************/

                                }
                                lstImportExcel = ValidateImport(lstImportExcel); //validate the rows with the system values 
                                if (lstImportExcel != null)
                                {


                                    foreach (var importExcelRow in lstImportExcel)
                                    {
                                        if (importExcelRow.IsVallid == true)
                                        {
                                            //save in database
                                        }
                                        else
                                        {
                                            //save records of error  that are not saved
                                            var errorImportExcelRow = new ImportExcelViewModel
                                            {


                                                email = importExcelRow.email,
                                                RowNb = importExcelRow.RowNb

                                            };
                                            errorLstImportExcel.Add(errorImportExcelRow);
                                        }
                                    }



                                }
                                else
                                {
                                    //something wrong in validation
                                    return Json(false);
                                }


                            }
                            //export to excel the error emails
                            ExcelPackage excel = new ExcelPackage();
                            var myworkSheet = excel.Workbook.Worksheets.Add("Sheet1");

                            //Header of table  
                            //  
                            myworkSheet.Row(1).Height = 20;
                            myworkSheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            myworkSheet.Row(1).Style.Font.Bold = true;
                            myworkSheet.Cells[1, 1].Value = "Row Number";
                            myworkSheet.Cells[1, 2].Value = "Email";

                            //Body of table  
                            //  
                            int recordIndex2 = 2;
                            foreach (var student in errorLstImportExcel)
                            {
                                myworkSheet.Cells[recordIndex2, 1].Value = student.RowNb.ToString();
                                myworkSheet.Cells[recordIndex2, 2].Value = student.email.ToString();

                                recordIndex2++;
                            }
                            myworkSheet.Column(1).AutoFit();
                            myworkSheet.Column(2).AutoFit();

                            var fileBytes2 = excel.GetAsByteArray();
                            Response.Clear();

                            Response.AppendHeader("Content-Length", fileBytes2.Length.ToString());
                            Response.AppendHeader("Content-Disposition",
                                String.Format("attachment; filename=\"{0}\"; size={1}; creation-date={2}; modification-date={2}; read-date={2}"
                                    , "temp.xlsx"
                                    , fileBytes2.Length
                                    , DateTime.Now.ToString("R"))
                                );
                            Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

                            Response.BinaryWrite(fileBytes2);
                            Response.End();

                            return Json(false);

                        }
                        return Json(false);
                    }
                    catch (Exception e)
                    {

                        return Json(false);
                    }

                }

                return Json(false);
            }
            catch (Exception e)
            {


                return Json(false);
            }
        }

        private List<ImportExcelViewModel> ValidateImport(List<ImportExcelViewModel> lstImportExcel)
        {
            throw new NotImplementedException();
        }

        public JsonResult GetData()
        {
            List<Product> products = new List<Product>()
            {
                new Product{ID=1,Name="Apple",Price=12 },
                new Product{ID=2,Name="Pear",Price=13 },
                new Product{ID=3,Name="Grape",Price=14 }
            };
            return Json(products, JsonRequestBehavior.AllowGet);
        }
        
    }
}