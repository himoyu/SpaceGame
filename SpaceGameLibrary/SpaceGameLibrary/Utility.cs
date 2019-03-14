﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colorful;

namespace SpaceGameLibrary
{
    public class Utility
    {
        public void DisplayHeader()
        {
            //Console.WriteLine("     /$$$$$$   /$$                               /$$$$$$$$                  /$$ ");
            //Console.WriteLine("    /$$__  $$ | $$                              |__  $$__/                 | $$ ");
            //Console.WriteLine("   | $$   __//$$$$$$    /$$$$$$   /$$$$$$          | $$  /$$$$$$   /$$$$$$ | $$   /$$");
            //Console.WriteLine("   |  $$$$$$|_  $$_/   |____  $$ /$$__  $$         | $$ /$$__  $$ /$$__  $$| $$  /$$/");
            //Console.WriteLine("     ____  $$ | $$      /$$$$$$$| $$   __/         | $$| $$   __/| $$$$$$$$| $$$$$$/");
            //Console.WriteLine("    /$$    $$ | $$ /$$ /$$__  $$| $$               | $$| $$      | $$_____/| $$_  $$");
            //Console.WriteLine("   |  $$$$$$/ |  $$$$/|  $$$$$$$| $$               | $$| $$      |  $$$$$$$| $$    $$");
            //Console.WriteLine(@"   \______/   \___/   \_______/|__/               |__/|__/       \_______/|__/  \__/  ");
            //Console.WriteLine(" $$$$$$$$                        $$                  $$       $$                  ");
            //Console.WriteLine("    $$ | $$$$$$   $$$$$$    $$$$$$$ | $$$$$$         $$ |$$$  $$ | $$$$$$    $$$$$$ ");
            //Console.WriteLine("    $$ |$$  __$$   ____$$  $$  __$$ |$$  __$$        $$ $$ $$ $$ |  ____$$  $$  __$$");
            //Console.WriteLine("    $$ |$$ |   __|$$$$$$$ |$$ /  $$ |$$$$$$$$ |      $$$$  _$$$$ | $$$$$$$ |$$ |   __|");
            //Console.WriteLine("    $$ |$$ |     $$  __$$ |$$ |  $$ |$$   ____|      $$$  /  $$$ |$$  __$$ |$$ |");
            //Console.WriteLine("    $$ |$$ |      $$$$$$$ | $$$$$$$ | $$$$$$$        $$  /    $$ | $$$$$$$ |$$ |");
            //Console.WriteLine("    __ | __ |       _______ |  _______ |  _______ |       __ /      __ |  _______ | __ |");
            List<string> storyFragments = new List<string>();

            storyFragments.Add(@"  /$$$$$$   /$$                               /$$$$$$$$                  /$$         ");
            storyFragments.Add(@" /$$__  $$ | $$                              |__  $$__/                 | $$         ");
            storyFragments.Add(@"| $$  \__//$$$$$$    /$$$$$$   /$$$$$$          | $$  /$$$$$$   /$$$$$$ | $$   /$$   ");
            storyFragments.Add(@"|  $$$$$$|_  $$_/   |____  $$ /$$__  $$         | $$ /$$__  $$ /$$__  $$| $$  /$$/   ");
            storyFragments.Add(@" \____  $$ | $$      /$$$$$$$| $$  \__/         | $$| $$  \__/| $$$$$$$$| $$$$$$/    ");
            storyFragments.Add(@" /$$  \ $$ | $$ /$$ /$$__  $$| $$               | $$| $$      | $$_____/| $$_  $$    ");
            storyFragments.Add(@"|  $$$$$$/ |  $$$$/|  $$$$$$$| $$               | $$| $$      |  $$$$$$$| $$ \  $$   ");
            storyFragments.Add(@" \______/   \___/   \_______/|__/               |__/|__/       \_______/|__/  \__/  ");
            storyFragments.Add(@"$$$$$$$$\                       $$\                 $$\      $$\                     ");
            storyFragments.Add(@"\__$$  __|                      $$ |                $$ | $\  $$ |                    ");
            storyFragments.Add(@"   $$ | $$$$$$\  $$$$$$\   $$$$$$$ | $$$$$$\        $$ |$$$\ $$ | $$$$$$\   $$$$$$\  ");
            storyFragments.Add(@"   $$ |$$  __$$\ \____$$\ $$  __$$ |$$  __$$\       $$ $$ $$\$$ | \____$$\ $$  __$$\ ");
            storyFragments.Add(@"   $$ |$$ |  \__|$$$$$$$ |$$ /  $$ |$$$$$$$$ |      $$$$  _$$$$ | $$$$$$$ |$$ |  \__|");
            storyFragments.Add(@"   $$ |$$ |     $$  __$$ |$$ |  $$ |$$   ____|      $$$  / \$$$ |$$  __$$ |$$ |      ");
            storyFragments.Add(@"   $$ |$$ |     \$$$$$$$ |\$$$$$$$ |\$$$$$$$\       $$  /   \$$ |\$$$$$$$ |$$ |      ");
            storyFragments.Add(@"   \__|\__|      \_______| \_______| \_______|      \__/     \__| \_______|\__|      ");

            int r = 225;
            int g = 255;
            int b = 250;
            for (int i = 0; i < storyFragments.Count; i++)
            {
                Colorful.Console.WriteLine(storyFragments[i], Color.FromArgb(r, g, b));

                r -= 9;
                b -= 9;
            }
        }
    }
}
