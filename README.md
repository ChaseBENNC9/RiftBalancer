# 7-Day Plan for Rift Balancer Demo

## Day 1: Project Setup and Player Movement (2-3 Hours)
### Tasks:
- **[0.5 hr]** Set up game engine (e.g., Unity, Godot)—new 2D project.  
- **[0.5 hr]** Create placeholder player sprite (e.g., rectangle).  
- **[1 hr]** Implement movement: left/right walk, jump, gravity.  
- **[0.5 hr]** Add static ground platform + camera follow.  

### Outcome:
Player moves/jumps on a surface—core physics ready.

---

## Day 2: Card System Framework and UI (2-3 Hours)
### Tasks:
- **[0.5 hr]** Define card template (buff/debuff)—6 placeholders.  
- **[1 hr]** Create hand UI—5-slot row (e.g., screen bottom).  
- **[0.5 hr]** Implement initial draw: 5 random cards at start.  
- **[0.5 hr]** Add selection (keys 1-5/click)—highlight only.  

### Outcome:
5-card hand visible/selectable—system skeleton set.

---

## Day 3: Checkpoints and Card Swapping Mechanics (2-3 Hours)
### Tasks:
- **[0.5 hr]** Create checkpoint object (e.g., glowing marker).  
- **[0.5 hr]** Place 2-3 checkpoints in test level.  
- **[1-1.5 hr]** Implement swap: discard active → pick new → draw to 5.  
- **[0.5 hr]** Test cycle with dummy effect (e.g., color change).  

### Outcome:
Checkpoints trigger swaps—loop functional, no effects.

---

## Day 4: Level Layout Basics (2-3 Hours)
### Tasks:
- **[1-1.5 hr]** Design short level: 3 checkpoints, gap, spikes, 1-2 glyphs.  
- **[0.5 hr]** Place checkpoints logically (e.g., post-gap).  
- **[0.5 hr]** Test movement through level—default physics.  

### Outcome:
Small level with checkpoints—ready for effects.

---

## Day 5: Implement Buff/Debuff Effects and Level Expansion (Full Day)
### Tasks:
- **[3-4 hr]** Implement 6 cards (e.g., "Double Jump + Inverted Controls" to "High Bounce + Random Shift")—buffs + debuffs.  
- **[1 hr]** Test swaps at checkpoints—effects apply/reset.  
- **[2-3 hr]** Expand level: 4-5 checkpoints, puzzles (gap, spikes), 2-3 glyphs, goal portal.  

### Outcome:
6 cards work, level has puzzles—gameplay loop solid.

---

## Day 6: Polish Mechanics and Deck Management (Full Day)
### Tasks:
- **[1 hr]** Add start checkpoint—initial card pick.  
- **[2-3 hr]** Tweak level: adjust puzzles for card variety, test flow.  
- **[1-2 hr]** Implement deck reshuffle—discard pile reused.  
- **[1-2 hr]** Basic polish: player tint per card, checkpoint glow, swap sound.  

### Outcome:
Refined level and mechanics—nearly demo-ready.

---

## Day 7: Finalize Playable Demo (3-4 Hours)
### Tasks:
- **[1 hr]** Finalize level: 4-5 checkpoints, puzzles solvable, goal clear.  
- **[1.5-2 hr]** Test mechanics: swaps (discard/pick/draw), 6 cards, glyph pickup—fix bugs.  
- **[0.5-1 hr]** Minimal polish: active card highlight, one sound (e.g., swap).  
- **[0.5 hr]** Export build—playable demo complete.  

### If Extra Time:
- Add 1-2 cards (e.g., "Sprint Burst + Spike Sting").  

### Outcome:
Playable demo—6 cards, 4-5 checkpoints, basic level.
