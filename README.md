# Quick Save/Load for Caves of Qud

Adds quick save/load hotkeys to Caves of Qud for convenient checkpointing during your adventures!

## Features

- **Quick Save**: Press F5 to create an instant checkpoint
- **Quick Load**: Press F6 to restore your last checkpoint
- **Simple and Fast**: No menu navigation required - just press the hotkey
- **Perfect for Risky Situations**: Save before dangerous encounters and reload if things go wrong

**Note:** Caves of Qud already has a built-in checkpoint system accessible through the menu (Esc > Save Checkpoint / Load Checkpoint). This mod simply adds convenient hotkeys (F5/F6) so you don't have to navigate menus every time.

## Installation

### Via Steam Workshop (Recommended)

[Subscribe on Steam Workshop](https://steamcommunity.com/sharedfiles/filedetails/?id=3660796791)

### Manual Installation

1. Download the [latest release](https://github.com/SattaRIP/caves-of-qud-quick-save-load/releases)
2. Copy the `TimeControl` folder to your Caves of Qud mods directory:
   - **Linux**: `~/.config/unity3d/Freehold Games/Caves of Qud/Mods/`
   - **Windows**: `%USERPROFILE%\AppData\LocalLow\Freehold Games\Caves of Qud\Mods\`
3. Launch Caves of Qud and enable the mod in the mod manager

### From Source

```bash
git clone https://github.com/SattaRIP/caves-of-qud-quick-save-load.git "~/.config/unity3d/Freehold Games/Caves of Qud/Mods/TimeControl"
```

## Controls

| Key | Action |
|-----|--------|
| **F5** | Quick Save |
| **F6** | Quick Load |

## How It Works

Uses Caves of Qud's built-in checkpoint system:
- F5 creates a checkpoint of your current game state
- F6 restores the last checkpoint you created
- Perfect for experimenting with dangerous situations or saving before important decisions

## Troubleshooting

**"No active game to save/load!"**
- Make sure you have a game loaded before using quick save/load

**Quick save/load doesn't work**
- Verify the mod is enabled in the mod manager
- Check that you have an active game (not in main menu)

## Credits

Created by mythraps

## License

Feel free to modify and share!
