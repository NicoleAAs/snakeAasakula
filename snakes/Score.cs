﻿using System;
using System.Collections.Generic;
using System.Text;

namespace snakes
{
    class Score
	{
		public void ScoreInGame(int Score)
		{

			int xOffset = 0;
			int yOffset = 25;
			Console.SetCursorPosition(xOffset, yOffset);
			WriteText("Score: " + Score, xOffset, yOffset);

		}
		
		public void WriteText(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}

	}
}
