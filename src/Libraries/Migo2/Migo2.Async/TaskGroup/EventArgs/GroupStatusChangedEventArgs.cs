// 
// GroupStatusChangedEventArgs.cs
//  
// Author:
//       Mike Urbanski <michael.c.urbanski@gmail.com>
// 
// Copyright (c) 2009 Michael C. Urbanski
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
 
using System;

namespace Migo2.Async
{
    public class GroupStatusChangedEventArgs : EventArgs
    {
        private readonly int remainingTasks;
        private readonly int runningTasks;
        private readonly int completedTasks;
        
        public int RemainingTasks {
            get { return remainingTasks; }
        }
        
        public int RunningTasks {
            get { return runningTasks; }
        }
        
        public int CompletedTasks {
            get { return completedTasks; }
        }    
 
        public GroupStatusChangedEventArgs (int remainingTasks,
                                            int runningTasks,
                                            int completedTasks)
        {
            this.remainingTasks = remainingTasks;
            this.runningTasks = runningTasks;
            this.completedTasks = completedTasks;
        }
    }   
}