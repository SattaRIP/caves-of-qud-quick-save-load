# Time Control Mod for Caves of Qud

Adds time control features to Caves of Qud, allowing you to save, load, and rewind time like in Baba Is You!

## Features

- **Quick Save/Load**: Press F5 to quick save, F9 to quick load (creates actual save files)
- **Rewind**: Press Ctrl+Z to step back one turn at a time
- **Redo**: Press Ctrl+Y to step forward through undone turns
- **Configurable History**: Adjust how many turns to store in the options menu (default: 10 turns)

## Installation

1. Copy the `TimeControl` folder to your Caves of Qud mods directory:
   - **Linux**: `~/.config/unity3d/Freehold Games/Caves of Qud/Mods/`
   - **Windows**: `%USERPROFILE%\AppData\LocalLow\Freehold Games\Caves of Qud\Mods\`

2. Launch Caves of Qud and enable the mod in the mod manager

## Controls

| Key | Action |
|-----|--------|
| **F5** | Quick Save (creates QuickSave.sav.gz) |
| **F9** | Quick Load (loads from QuickSave.sav.gz) |
| **Ctrl+Z** | Rewind one turn |
| **Ctrl+Y** | Redo one turn (after rewinding) |

## Configuration

Access the mod settings in **Options > Mod: Time Control**:

- **Rewind History Size**: Choose how many turns to store
  - 5 turns: Minimal memory usage
  - 10 turns: Recommended (default)
  - 20 turns: Moderate memory usage
  - 50 turns: High memory usage (may cause lag)
  - 100 turns: Very high memory usage (not recommended)

- **Enable Rewind**: Toggle the rewind feature on/off

## How It Works

### Quick Save/Load
- Creates a separate save file (QuickSave.sav.gz) that doesn't interfere with your regular saves
- Survives game crashes and exits
- Perfect for saving before risky situations

### Rewind/Redo
- Stores game state snapshots in memory for the last N turns
- Step backward through time with Ctrl+Z
- Step forward again with Ctrl+Y
- Taking a new action after rewinding clears the redo buffer (prevents timeline branching)
- History is lost when you exit the game

## Performance Notes

- Rewind uses in-memory snapshots, which consume RAM
- Default 10 turns = ~10-100MB depending on game state
- Higher values may cause lag on systems with limited RAM
- If you experience performance issues, reduce the history size or disable rewind

## Known Limitations

- Random events may differ after rewinding (RNG state not saved)
- Very large game states (massive inventory, many effects) take longer to snapshot
- Rewind history is cleared on game exit

## Troubleshooting

**"No quick save found!"**
- You need to press F5 to create a quick save before you can press F9 to load it

**"No history to rewind!"**
- History starts accumulating after you load/start a game
- Try taking a few turns first

**Game lags after each turn**
- Reduce the history size in options
- Or disable rewind entirely if you only want quick save/load

**Quick save/load doesn't work**
- Make sure you have an active game loaded
- Check that you have write permissions in the save directory

## Credits

Created by mythraps
Inspired by Baba Is You's rewind mechanic

## License

Feel free to modify and share!
