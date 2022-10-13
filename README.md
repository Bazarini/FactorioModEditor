# FactorioModEditor
Hi everyone!
This tool is currently in development. The goal is to create an interface to create mods for Factorio faster and with less error rate.
Currently I am using .NET Core + WPF for UI. Please check description below and let me know if you have any ideas on what to add or change.

This is a pet project, thus, it can be updated not regularly.

## RoadMap:

### I Milestone (MVP):

	The aim for this milestone is to get a tool capable of creating a simple mod like a big assembler with a new recipes.

- [ ] Add entities for basic objects (e.g recipes, entities, items, tech...).
- [ ] Add a lua code converter to save objects as they should be in the mod.
- [ ] Add WPF windows.
- [ ] Add serialization of models for saving/loading.
- [ ] Add title window for new mod or loading existing.
- [ ] Add mod info edit window.
- [ ] Add Export button for building a mod to the selected folder.

### II Milestone:

	The goal of this milestone is to upgrade a tool to support more complex mods with more features.

- [ ] Add Settings window and models.
- [ ] Add dependency load for other mods created using this editor.
- [ ] Add three-stage-load separation (data, data-updates...).
- [ ] Add data.raw referencing to copy or edit existing objects.
- [ ] Add Item placement window for preview of the item as it is in the game.
- [ ] Add localization editor window.
- [ ] Add text editor for script editing (TBD).
- [ ] Add migrations generation (TBD).

### III Milestone (QOL):
	
	The goal of this milestone is to add optional fatures which will make modding faster and more comfortable.

- [ ] Add help references for Lua scripting, Factorio API and mod creation.
- [ ] Add factorio folders select screen.
- [ ] Add build and run option to build a mod, place it in the folder and run a game.
- [ ] Add mod reading service to at least try to analyze existing mod, create entities and save as a project.
- [ ] Add localization of the editor. For now - English and Ukrainian (other languages TBD).
- [ ] Add in-game help creation via [Informatron](https://mods.factorio.com/mod/informatron)
