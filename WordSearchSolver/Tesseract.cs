﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Patagames.Ocr;
using Patagames.Ocr.Enums;

namespace WordSearchSolver
{
    public class Tesseract
    {
        public static string ConvertImageToText(string filePath)
        {
            string plainText = "Error 505";
            using (var api = OcrApi.Create())
            {
                api.Init(Languages.Lithuanian, "./");
                plainText = api.GetTextFromImage(filePath);
            }
            return plainText;
        }
    }
}
