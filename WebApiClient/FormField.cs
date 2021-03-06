﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WebApiClient
{
    /// <summary>
    /// 表示将自身作为x-www-form-urlencoded的字段
    /// </summary>
    [DebuggerDisplay("{stringValue}")]
    public class FormField : IApiParameterable
    {
        /// <summary>
        /// 文本内容
        /// </summary>
        private readonly string stringValue;

        /// <summary>
        /// 将自身作为x-www-form-urlencoded的字段
        /// </summary>     
        /// <param name="value">文本内容</param>
        public FormField(object value)
        {
            this.stringValue = value == null ? string.Empty : value.ToString();
        }

        /// <summary>
        /// x-www-form-urlencoded的字段
        /// 如果有[FormContent]的参数，FormField需要放在其后
        /// </summary>     
        /// <param name="value">文本内容</param>
        public FormField(string value)
        {
            this.stringValue = value;
        }

        /// <summary>
        /// http请求之前
        /// </summary>
        /// <param name="context">上下文</param>
        /// <param name="parameter">特性关联的参数</param>
        /// <returns></returns>
        async Task IApiParameterable.BeforeRequestAsync(ApiActionContext context, ApiParameterDescriptor parameter)
        {
            await context.RequestMessage.AddFieldAsync(parameter.Name, this.stringValue);
        }

        /// <summary>
        /// 从string类型隐式转换
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator FormField(string value)
        {
            return new FormField(value);
        }

        /// <summary>
        /// 从int类型隐式转换
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator FormField(int value)
        {
            return new FormField(value);
        }

        /// <summary>
        /// 从int?类型隐式转换
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator FormField(int? value)
        {
            return new FormField(value);
        }

        /// <summary>
        /// 从decimal类型隐式转换
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator FormField(decimal value)
        {
            return new FormField(value);
        }

        /// <summary>
        /// 从decimal?类型隐式转换
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator FormField(decimal? value)
        {
            return new FormField(value);
        }

        /// <summary>
        /// 从double类型隐式转换
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator FormField(double value)
        {
            return new FormField(value);
        }

        /// <summary>
        /// 从double?类型隐式转换
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator FormField(double? value)
        {
            return new FormField(value);
        }

        /// <summary>
        /// 从DateTime类型隐式转换
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator FormField(DateTime value)
        {
            return new FormField(value);
        }

        /// <summary>
        /// 从DateTime?类型隐式转换
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator FormField(DateTime? value)
        {
            return new FormField(value);
        }
    }
}
