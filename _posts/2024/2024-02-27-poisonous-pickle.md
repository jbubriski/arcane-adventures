---
layout:     post
title:      "Poisoned Pickle - Magic Item for DnD"
title_simple:      "Poisoned Pickle"
date:       2024-02-22 10:00:00 -0400
categories: magic-item
tags:       dnd dnd-5e magic-item multi-use tier-1 tier-2 tier-3 tier-4
magicItemType: wondrous item
rarity:     common
requires_attunement: false
image_suffix: webp
image_base_path: /assets/images/poisoned-pickle/
image:      poisonous-pickle-01
images:
    - src: poisoned-pickle-01
      alt: Poisoned Pickle
    - src: poisoned-pickle-02
      alt: Alternate image for Poisoned Pickle
---

<div class="read-aloud">
    Someone has sent you a wonderfully fresh jar of pickles, straight from the city! Look! The date is even stamped on the jar and they were only made available for sale yesterday! How wonderful. Only these aren't just any ordinary pickles! They're straight from Entellion the Master Pickler! Also, they're poisoned.
</div>
<div class="read-aloud">
    But who would poison pickles? Surely Entellion knows nothing of this dastardly business so who could it be? Was it the tavern keeper holding your gift for you? Was it the courier that rushed the jar from the city? Or was it an intermediary who purchased the jar from Entellion, added the insidious poison to the jar, and then paid the courier a handsom fee to rush the pickles to their destination?
</div>

The pickle jar contains 3d6 large poisoned pickles.

{% assign image = page.images[1] %}
{% include post-image.html side="right" src=image.src alt=image.alt size=320 %}

A creature's passive perception may be enough to detect that the jar has been tampered with and is no longer "factory sealed". A creature inspecting the jar can also roll a
perception skill check to see if they spot the tampering.

{% include descriptions/tiered-play.html %}

| Tier of Play | Perception Check
| ---------------------- | - |
| [1][tier1_description] | 15
| [2][tier2_description] | 20
| [3][tier3_description] | 25
| [4][tier4_description] | 30

If consumed, a creature will suffer poison damage and other effects depending on the tier.

| Tier of Play | Constitution DC | Poison Effect
| ---------------------- | - | - |
| [1][tier1_description] | DC 14 | 2d6 poison damage and 2 levels of exhaustion
| [2][tier2_description] | DC 18 | 4d6 poison damage and 3 levels of exhaustion
| [3][tier3_description] | DC 24 | 6d6 poison damage and 4 levels of exhaustion
| [4][tier4_description] | DC 30 | 8d6 poison damage and 5 levels of exhaustion


## DM Note

My original thought for this poisoned item was for it to be a straight forward trap. It would be sent to the adventurer's as part of a package congratulating them for a deed they had _just_ accomplished, meaning it was a bit too soon for news to have spread. The package would be signed with the name of a  The party did not have a direct way to detect poison, but a simple inspection might reveal that the item was a trap. I was considering making the check automatic if they realized that the situation was very suspect.

If the adventurers do become poisoned, feel free to flavor up the situation. Maybe the poison damage isn't taken immediately, but will slowly deal damage if left untreated, or if they go to sleep feeling sickly they'll wake up on death's door. Give the players opportunities to remedy the situation (and the poison).


## Attribution

{% include srd_attribution.html %}
