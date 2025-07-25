﻿// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright (c) 2025 Niklas Swärd
// https://github.com/NickSwardh/YoloDotNet

namespace YoloDotNet.Video.Services
{
    public class Processor
    {
        public static Process Create(string fileName, IEnumerable<string> arguments)
        { 
            var process = new Process()
               {
                   StartInfo = new ProcessStartInfo
                   {
                       FileName = fileName,
                       UseShellExecute = false,
                       RedirectStandardOutput = true,
                       RedirectStandardError = true,
                       RedirectStandardInput = true,
                       CreateNoWindow = true
                   },

                   EnableRaisingEvents = true,
               };

            // Add each argument safely to ArgumentList
            foreach (var arg in arguments)
                process.StartInfo.ArgumentList.Add(arg);

            return process;

        }
    }
}
