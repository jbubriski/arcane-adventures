---
layout:         post
title:          "Trick Crystal Ball - Magic Item for DnD"
title_simple:   "Trick Crystal Ball"
date:           2024-01-16 10:00:00 -0400
categories:     magic-item
tags:           dnd dnd-5e tier-1 tier-2 tier-3 tier-4
magicItemType:  wondrous item
rarity:         rare
requires_attunement: false
image_base_path: /assets/images/trick-crystal-ball/
image_suffix: png
image:      trick-crystal-ball-01
images:
    - src: trick-crystal-ball-01
      alt: Trick Crystal Ball
    - src: trick-crystal-ball-02
      alt: Alternate image of Trick Crystal Ball
---

<p class="read-aloud">
    Jasine knew the good-hearted apprentice would be thrilled to return a lost crystal ball to its owner. The apprentice even decided to make a show of it and surprise his teacher. A surprise indeed. She would be long gone from the region when the deed was done.
</p>
<!--more-->

{% assign image = page.images[1] %}
{% include post-image.html side="right" src=image.src alt=image.alt size=320 %}

Trick crystal balls range in their application from simple harmless pranks to deadly traps concocted by dastardly magic users. Specific effects can vary from showing the wrong prophecy to exploding in the face of the user.

Roll on the tables below for the specific effect.

<div markdown="block" class="roll-table js-autoroll js-roll-table">
| {% include tools/dice-roll.html type="Harmless Trick Crystal Ball Effect" roll="1d4" text="Roll" %} | Harmless Trick Crystal Ball Effect |
| ---------------------- | -- |
| 1 | Harmless misstep: The crystal ball provides a small glimpse into the future, but provides the opposite of what will happen. Use a relative effect like causing an NPC to be insulated when the adventure tries to play out the prophecy.
| 2 | Loading: The crystal ball constantly swirls and appears to form shapes, but they quickly morph and dissipate into other shapes, infinitely.
| 3 | Jumpscare: The crystal ball shows something in the swirling mist. When a player looks closely a scary face appears. Roll a DC 10 Dexterity saving throw. On a failed save fall out of your chair or fall backwards.
| 4 | Return to... somone? The crystal ball claims to be the property of a powerful wizard and demands to be returned. It turns out the "owner" isn't really the owner, and may not even be a wizard at all!

</div>

<div markdown="block" class="roll-table js-autoroll js-roll-table">
| {% include tools/dice-roll.html type="Deadly Trick Crystal Ball Effect" roll="1d4" text="Roll" %} | Deadly Trick Crystal Ball Effect |
| ---------------------- | -- |
| 1 | Deadly misstep: The crystal ball provides a small glimpse into the future, but shows the opposite of what will happen. Use a relative effect like causing a combat encounter if the adventurers attempt to live out the prophecy.
| 2 | Booby trap: The crystal ball immediately explodes or releases a harmful spell effect when used.
| 3 | Assassination attempt: The crystal ball lies and asks to be brought to its former master, but will explode when brought to the specific person.
| 4 | Return to sender: The crystal ball claims to be the property of a powerful wizard and demands to be returned to its benevolent master. In truth the owner is an evil spellcaster who won't want his whereabouts known to random adventurers.

</div>


## Additional Images

{% include additional-images-dall-e.html %}

{% include additional-images.html %}


## Attribution

{% include srd_attribution.html %}
