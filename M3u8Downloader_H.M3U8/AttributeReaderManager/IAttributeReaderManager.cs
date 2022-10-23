﻿using M3u8Downloader_H.M3U8.AttributeReaders;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3u8Downloader_H.M3U8.AttributeReaderManager
{
    public interface IAttributeReaderManager
    {
        IAttributeReader this[string key] { get; set; }

        /// <summary>
        /// 当原始的标签没有的情况下可以使用此函数，如果想替换程序内部的某个标签，用上面的dict["key"] 这种方式赋值
        /// </summary>
        /// <param name="key">m3u8的标签，完整的包含#号</param>
        /// <param name="value">实现了IAttributeReader接口的类new进来</param>
        void Add(string key, IAttributeReader value);

        /// <summary>
        /// 是否包含某个标签
        /// </summary>
        /// <param name="key">m3u8的标签，完整的包含#号</param>
        /// <returns>包含为真，否则为假</returns>
        bool ContainsKey(string key);

        /// <summary>
        /// 获取某个标签的值
        /// </summary>
        /// <param name="key">m3u8的标签，完整的包含#号</param>
        /// <param name="value">返回得到的值</param>
        /// <returns>包含此标签的为真，否则为假</returns>
        bool TryGetValue(string key, [MaybeNullWhen(false)] out IAttributeReader value);
    }
}
