﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace vitorrdgs.Util
{
    public class EmailClient
    {
        private string _smtpHost;
        private bool _smtpSsl = true;
        private int _smtpPort = 587;

        private string _credentialEmail;
        private string _credentialPassword;

        public string SmtpHost { get => _smtpHost; set => _smtpHost = value; }
        public bool SmtpSsl { get => _smtpSsl; set => _smtpSsl = value; }
        public int SmtpPort { get => _smtpPort; set => _smtpPort = value; }
        public string CredentialEmail { get => _credentialEmail; set => _credentialEmail = value; }
        public string CredentialPassword { get => _credentialPassword; set => _credentialPassword = value; }

        public string SendEmail(string senderName, string senderEmail, string receiverEmail, string title, StringBuilder message, string template)
        {
            Dictionary<string, StringBuilder> values = new Dictionary<string, StringBuilder>();
            values.Add("TITULO", new StringBuilder(title));
            values.Add("MENSAGEM", message);

            StringBuilder content = UtilTemplate.parseTemplate(template, values);

            return SendEmail(senderName, senderEmail, receiverEmail, senderName + " - " + title, content.ToString());
        }

        public string SendEmail(string senderName, string senderEmail, string receiverEmail, string title, string content)
        {
            MailAddress objSender = new MailAddress(senderName + "<" + senderEmail + ">");

            MailMessage objMessage = new MailMessage
            {
                From = objSender,
                Priority = MailPriority.Normal,
                IsBodyHtml = true,
                Subject = title,
                Body = content,
                SubjectEncoding = System.Text.Encoding.GetEncoding("UTF-8"),
                BodyEncoding = System.Text.Encoding.GetEncoding("UTF-8")
            };
            objMessage.To.Add(receiverEmail);
            objMessage.ReplyToList.Add(objSender);

            NetworkCredential objCredential = new NetworkCredential
            {
                UserName = CredentialEmail,
                Password = CredentialPassword
            };

            SmtpClient objSmtp = new SmtpClient
            {
                Host = SmtpHost,
                EnableSsl = SmtpSsl,
                Port = SmtpPort,
                UseDefaultCredentials = true,
                Credentials = objCredential
            };

            try
            {
                objSmtp.Send(objMessage);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                objMessage.Dispose();
            }
            return "";
        }
    }
}
