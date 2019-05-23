﻿using System;
using System.Collections;
using System.Collections.Generic;
using TileScripts;
using UnityEngine;

namespace TileScripts.SpecialTiles
{
    public class InJailTile : Tile
    {
        public override void SetUpTile(String incomingTileName, Vector3 incomingTilePosition, int[] incomingTileValues)
        {
            tileName = incomingTileName;
            TilePosition = incomingTilePosition;
        }
        
        public override void DoTileAction()
        {
                
        }
    }
}