using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.G2C
{
    public class SCTeamPingPosPacket : GamePacket
    {
        public SCTeamPingPosPacket(uint hasPing, float x, float y, uint insId) : base(0x0e0, 1)
        {
            // TODO not done... need client packet
        }

        public override PacketStream Write(PacketStream stream)
        {
            
            return stream;
        }
    }
}
