﻿using System.Text;

namespace RequestsHub.Presentation.ConsoleServices;

internal static class Documentation
{
    internal static StringBuilder GetDocAboutCommands()
    {
        StringBuilder help = new StringBuilder("usage:");
        help.AppendLine("RequestsHub.exe [options] ");
        return help;
    }
}