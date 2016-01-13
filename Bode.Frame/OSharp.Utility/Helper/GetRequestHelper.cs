﻿// -----------------------------------------------------------------------
//  <copyright file="HttpRequestExtensions.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2015 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>imbedinlove@gmail.com</last-editor>
//  <last-date>2015年11月6日 16:33:16</last-date>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using OSharp.Utility.Extensions;

namespace OSharp.Utility.Helper
{
    /// <summary>
    /// 网页请求枚举
    /// </summary>
    public enum RequestMethod
    {
        Post,
        Get
    }

    public class GetRequestHelper
    {
        /// <summary>
        /// 网页请求
        /// </summary>
        /// <param name="postUrl">URL</param>
        /// <param name="requestMethod">请求方法</param>
        /// <param name="param">请求参数</param>
        /// <param name="encoding">编码</param>
        /// <param name="headers">头部</param>
        /// <returns></returns>
        public static string GetWebRequest(string postUrl, RequestMethod requestMethod = RequestMethod.Get ,string param = null, Encoding encoding = null, WebHeaderCollection headers = null, CookieContainer cookie = null)
        {
            postUrl = postUrl.FormatHost();
            string ret = string.Empty;
            HttpWebResponse response;
            StackTrace st = new StackTrace(true);
            try
            {
                if (encoding == null)
                {
                    encoding = Encoding.UTF8;
                }
                HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(new Uri(postUrl));
                if (cookie != null)
                {
                    webRequest.CookieContainer = cookie;
                }
                if (headers != null) webRequest.Headers = headers;
                webRequest.Method = requestMethod.ToString();
                webRequest.ContentType = "application/x-www-form-urlencoded";
                webRequest.UserAgent = "User-Agent";
                webRequest.KeepAlive = true;
                if (param != null && requestMethod == RequestMethod.Post)
                {
                    byte[] paramByte = encoding.GetBytes(param);
                    webRequest.ContentLength = paramByte.Length;
                    var webStream = webRequest.GetRequestStream();
                    webStream.Write(paramByte, 0, paramByte.Length);
                    webStream.Close();
                }
                response = (HttpWebResponse)webRequest.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream(), encoding);
                ret = sr.ReadToEnd();
                sr.Close();
                response.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return ret;
        }

        public static CookieContainer GetCookies(string postUrl, string paramData, Encoding dataEncode = null)
        {
            if (dataEncode == null)
            {
                dataEncode = Encoding.UTF8;
            }
            postUrl = postUrl.FormatHost();
            string ret = string.Empty;
            HttpWebResponse response;
            StackTrace st = new StackTrace(true);
            CookieContainer cookieEx = new CookieContainer();
            try
            {
                byte[] byteArray = dataEncode.GetBytes(paramData); //转化
                HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(new Uri(postUrl));
                webRequest.Method = RequestMethod.Post.ToString();
                webRequest.ContentType = "application/x-www-form-urlencoded";
                webRequest.KeepAlive = true;

                byte[] paramByte = dataEncode.GetBytes(paramData);
                webRequest.ContentLength = paramByte.Length;
                var webStream = webRequest.GetRequestStream();
                webStream.Write(paramByte, 0, paramByte.Length);
                webStream.Close();

                response = (HttpWebResponse)webRequest.GetResponse();
                if (webRequest.CookieContainer != null)
                {
                    response.Cookies = webRequest.CookieContainer.GetCookies(webRequest.RequestUri);
                    cookieEx.Add(response.Cookies);
                }
                StreamReader sr = new StreamReader(response.GetResponseStream(), dataEncode);
                ret = sr.ReadToEnd();
                sr.Close();
                response.Close();
            }
            catch (Exception e)
            {
                throw;
            }
            return cookieEx;
        }
    }
}
