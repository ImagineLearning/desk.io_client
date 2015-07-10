using System.Net;
using System.Net.Sockets;
using System.Text;

namespace DeskIO.Droid
{
	public class Desk
	{
		public const int DeskIOSocketPort = 8000;
		public IPAddress DeskControllerIpAddress { get; private set; }

		private Socket _deskSocket;

		public Desk(IPAddress deskControllerIpAddress)
		{
			DeskControllerIpAddress = deskControllerIpAddress;

			_deskSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			_deskSocket.Connect(DeskControllerIpAddress, DeskIOSocketPort);
		}

		public void Raise(int duration = -1)
		{
			MoveDesk(MovementDirection.Up, duration);
		}

		public void Lower(int duration = -1)
		{
			MoveDesk(MovementDirection.Down, duration);
		}

		private void MoveDesk(MovementDirection direction, int movementDuration)
		{
			var commandString = direction.ToString();

			if (movementDuration > 0)
				commandString += " " + movementDuration;

			var command = Encoding.UTF8.GetBytes(commandString);

			_deskSocket.Send(command);
		}

		public void Stop()
		{
			var command = Encoding.UTF8.GetBytes("Stop");
			_deskSocket.Send(command);
		}

		public void Disconnect()
		{
			_deskSocket.Shutdown(SocketShutdown.Both);
			_deskSocket.Close();
		}
	}

	public enum MovementDirection
	{
		Up,
		Down
	}
}
