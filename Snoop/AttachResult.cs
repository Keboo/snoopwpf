// (c) Copyright Cory Plotts.
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.

namespace Snoop
{
    using System;

    public class AttachResult
    {
        public AttachResult()
        {
            this.Success = true;
        }

        public AttachResult(Exception attachException)
        {
            this.Success = false;

            this.AttachException = attachException;
        }

        public AttachResult(Exception attachException, string windowName)
        {
            this.Success = false;

            this.AttachException = attachException;
            this.WindowName = windowName;
        }

        public bool Success { get; }

        public Exception AttachException { get; }

        public string WindowName { get; }
    }
}