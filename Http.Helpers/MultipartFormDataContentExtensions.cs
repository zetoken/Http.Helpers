using System.IO;
using System.Net.Http;

namespace ZTn.Http.Helpers
{
    public static class MultipartFormDataContentExtensions
    {
        /// <summary>
        /// Add any <see cref="HttpContent"/> as a file to a form.
        /// </summary>
        /// <param name="form">The form.</param>
        /// <param name="content"><inheritdoc cref="MultipartFormDataContent.Add(HttpContent,string,string)" select="param[@name='content']"/></param>
        /// <param name="name"><inheritdoc cref="MultipartFormDataContent.Add(HttpContent,string,string)" select="param[@name='name']"/></param>
        /// <param name="fileName"><inheritdoc cref="MultipartFormDataContent.Add(HttpContent,string,string)" select="param[@name='fileName']"/></param>
        /// <returns></returns>
        public static MultipartFormDataContent AddAsFile(this MultipartFormDataContent form, HttpContent content, string name, string fileName)
        {
            form.Add(content, name, fileName);

            return form;
        }

        /// <summary>
        /// Add any <see cref="Stream"/> as a file to a form.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="name"><inheritdoc cref="MultipartFormDataContent.Add(HttpContent,string)" select="param[@name='name']"/></param>
        /// <param name="stream"></param>
        /// <param name="fileName"><inheritdoc cref="MultipartFormDataContent.Add(HttpContent,string,string)" select="param[@name='fileName']"/></param>
        /// <returns></returns>
        public static MultipartFormDataContent AddAsFile(this MultipartFormDataContent form, string name, Stream stream, string fileName)
        {
            form.AddAsFile(new StreamContent(stream), name, fileName);

            return form;
        }

        /// <summary>
        /// Add any <see cref="string"/> as a file to a form.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="name"><inheritdoc cref="MultipartFormDataContent.Add(HttpContent,string)" select="param[@name='name']"/></param>
        /// <param name="data"></param>
        /// <param name="fileName"><inheritdoc cref="MultipartFormDataContent.Add(HttpContent,string,string)" select="param[@name='fileName']"/></param>
        /// <returns></returns>
        public static MultipartFormDataContent AddAsFile(this MultipartFormDataContent form, string name, string data, string fileName)
        {
            form.AddAsFile(new StringContent(data), name, fileName);

            return form;
        }

        /// <summary>
        /// Add any byte array as a file to a form.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="name"><inheritdoc cref="MultipartFormDataContent.Add(HttpContent,string)" select="param[@name='name']"/></param>
        /// <param name="data"></param>
        /// <param name="fileName"><inheritdoc cref="MultipartFormDataContent.Add(HttpContent,string,string)" select="param[@name='fileName']"/></param>
        /// <returns></returns>
        public static MultipartFormDataContent AddAsFile(this MultipartFormDataContent form, string name, byte[] data, string fileName)
        {
            form.AddAsFile(new ByteArrayContent(data), name, fileName);

            return form;
        }

        /// <summary>
        /// Add any <see cref="string"/> as a field to a form.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="name"><inheritdoc cref="MultipartFormDataContent.Add(HttpContent,string)" select="param[@name='name']"/></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static MultipartFormDataContent AddAsString(this MultipartFormDataContent form, string name, string value)
        {
            form.Add(new StringContent(value), name);

            return form;
        }

        /// <summary>
        /// Add any byte array as a field to a form.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="name"><inheritdoc cref="MultipartFormDataContent.Add(HttpContent,string)" select="param[@name='name']"/></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static MultipartFormDataContent AddAsBytes(this MultipartFormDataContent form, string name, byte[] data)
        {
            form.Add(new ByteArrayContent(data), name);

            return form;
        }
    }
}
