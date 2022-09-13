using System;

namespace WoodyCad
{
    public class ByteBuider
    {
        private byte[] result;

        public ByteBuider()
        {
            result = new byte[0];
        }

        public byte[] Result { get => result; }

        public void Write(byte[] o)
        {
            Combine(o);
        }

        public void WriteLine(string msg)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(msg + "\r\n");
            Combine(bytes);
        }

        private void Combine(byte[] o)
        {
            byte[] ret = new byte[Result.Length + o.Length];
            Buffer.BlockCopy(Result, 0, ret, 0, Result.Length);
            Buffer.BlockCopy(o, 0, ret, Result.Length, o.Length);
            result = ret;
        }

    }
}
