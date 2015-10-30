using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_5
{
	public class ScoreController
	{
		private ScoreModel scoreModel;
		private ScoreView scoreView;
		static int roundScore;
		static int totalScore;

		public ScoreController ()
		{
			scoreModel = new ScoreModel();
			scoreView = new ScoreView( this );
		}

		public ScoreView getView()
		{
			return scoreView;
		}

		public ScoreModel getModel()
		{
			return scoreModel;
		}

		public void IncreaseScore(int amount)
		{
			roundScore += amount;
			totalScore += amount;
		}

		public void UpdateScore()
		{

			scoreView.UpdateLabel(roundScore);
		}

		public void UpdateTotalScore()
		{

			scoreView.UpdateTotalLabel(totalScore);
		}
	}
}
