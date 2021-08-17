using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCsharpLibrary.Patterns.Design.Creational.Builder.Builders;
using LearningCsharpLibrary.Patterns.Design.Creational.Builder.Directors;

namespace LearningCsharpLibrary.Patterns.Design.Creational.Builder
{
    internal class LearningBuilder : IDemo
    {
        public void Demo()
        {
            Report report;

            Director1 reportDirector = new();

            PDFReportBuilder pdfReportBuilder = new();
            report = reportDirector.MakeReport(pdfReportBuilder);
            report.DisplayReport();

            Console.WriteLine("-------------------");

            ExcelReportBuilder excelReportBuilder = new ExcelReportBuilder();
            report = reportDirector.MakeReport(excelReportBuilder);
            report.DisplayReport();
        }
    }
}