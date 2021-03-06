﻿using System;
using System.Threading;
using glfw3;

namespace Examples
{
    public class WindowCreation
    {
        public static void Main(string[] args)
        {
            Glfw.SetErrorCallback((error, description) => { Console.WriteLine($"GLFW Error {error}: {description}"); });
            Glfw.Init();
            
            var win = Glfw.CreateWindow(400, 400, "GLFW Window", IntPtr.Zero, IntPtr.Zero);

            while(Glfw.WindowShouldClose(win) == Glfw.False)
            {
                Glfw.PollEvents();
                
                Thread.Sleep(100);
                Console.Clear();
            }
        }
    }
}