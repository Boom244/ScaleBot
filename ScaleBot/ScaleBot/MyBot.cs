using System;
using System.IO;
using System.Text;
using Discord;
using Discord.Commands;
namespace ScaleBot
{
	public class MyBot
	{
		DiscordClient discord;
		public MyBot()
		{
			discord = new DiscordClient(x =>
			{
				x.LogLevel = LogSeverity.Info;
				x.LogHandler = Log;
			});
			discord.ExecuteAndWait(async () =>
			{
				
				try
				{
					string ReadText = File.ReadAllText("Token.txt");
					await discord.Connect(ReadText, TokenType.Bot);
				}
				catch (Exception e)
				{
					Console.WriteLine("Could not find tokenfile.");
				}
			});
		       
		}	private void Log(object sender, LogMessageEventArgs e)
		    {
			Console.Write(e.Message);
			}

	}
	}

