using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "3321747055@qq.com";
            string password = "mqruvkojqhfzcgjd";
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.qq.com";
            smtpClient.Credentials = new System.Net.NetworkCredential(username, password);
            string strfrom = username;
            string strto = "qianyonglian@outlook.com";
            string subject = "SUbject";
            string body = "";
            body += @"<style type='text/css'> 
        table,
        table tr th,
        table tr td {
                border: 1px solid #0094ff;
        }
            table {
                width: 200px;
                min - height: 25px;
                line - height: 25px;
                text - align: center;
           border-collapse: collapse;
            padding: 1px;
            }
    </style>";
            body += @"<div>
        <table>
            <tr>
                <th>ID</th>
                <th>Name</th>
            </tr>
            <tr>
                <td>1</td>
                <td>Apple</td>
            </tr>
            <tr>
                <td>2</td>
                <td>Pear</td>
            </tr>
        </table>
    </div>";


            MailMessage mm = new MailMessage();
            mm.From = new MailAddress(strfrom);
            mm.To.Add(strto);
            mm.Subject = subject;
            mm.Body = body;
            mm.IsBodyHtml = true;
            try
            {
                smtpClient.Send(mm);
                Console.WriteLine("Send Successfully");
            }
            catch (Exception)
            {
                throw;
            }
            Console.WriteLine("....");
        }
    }
}
