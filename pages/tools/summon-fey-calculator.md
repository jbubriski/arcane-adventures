---
layout:       page
title:        "2014 D&D Tools - Summon Fey Calculator"
sub_title:    Summon Fey Calculator
description:  A collection of character builds for your DnD 5e or other tabletop game
permalink:    /tools/summon-fey-calculator
---

<script defer src="https://cdn.jsdelivr.net/npm/alpinejs@3.x.x/dist/cdn.min.js"></script>

<div class="page" x-data="{ edition: 2024, spellLevel: '3', characterLevel: '5' }">

<div class="stat-block-calculator">
    <h3>Configure</h3>
    <table>
        <tr>
            <td>
                <label for="edition">Edition</label>
            </td>
            <td>
                <select id="edition" x-model="edition">
                    <option value="2014">2014</option>
                    <option value="2024">2024</option>
                </select>
            </td>
        </tr>
        <tr>
            <td>
                <label for="spell_level">Spell Level</label>
            </td>
            <td>
                <select id="spell_level" x-model="spellLevel">
                    <option value="3">3</option>
                    <option value="4">4</option>
                    <option value="5">5</option>
                    <option value="6">6</option>
                    <option value="7">7</option>
                    <option value="8">8</option>
                    <option value="9">9</option>
                </select>
            </td>
        </tr>
    </table>
</div>

<div class="stat-block-calculator-results">
    <h3>Results</h3>
    <table>
        <tr>
            <td>HP</td>
            <td x-text="(parseInt(spellLevel) - 3) * 10 + 30"></td>
        </tr>
        <tr>
            <td>AC</td>
            <td x-text="parseInt(spellLevel) + 12"></td>
        </tr>
        <tr x-show="edition == '2014'">
            <td>Shortsword damage</td>
            <td>1d6 + <span x-text="parseInt(spellLevel) + 3"></span> piercing damage + 1d6 force damage</td>
        </tr>
        <tr x-show="edition == '2024'">
            <td>Fey Blade damage</td>
            <td>2d6 + <span x-text="parseInt(spellLevel) + 3"></span> Force damage</td>
        </tr>
        <tr>
            <td># of Attacks</td>
            <td x-text="Math.floor(spellLevel / 2)"></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <div x-show="edition == '2014'">
                    <div x-show="elementType == 'Air'">Slam: 1d10 + <span x-text="4 + parseInt(spellLevel)"></span> bludgeoning damage</div>
                    <div x-show="elementType == 'Earth'">Slam: 1d10 + <span x-text="4 + parseInt(spellLevel)"></span> bludgeoning damage</div>
                    <div x-show="elementType == 'Fire'">Slam: 1d10 + <span x-text="4 + parseInt(spellLevel)"></span> fire damage</div>
                    <div x-show="elementType == 'Water'">Slam: 1d10 + <span x-text="4 + parseInt(spellLevel)"></span> bludgeoning damage</div>
                </div>
                <div x-show="edition == '2024'">
                    <div x-show="elementType == 'Air'">Slam: 1d10 + <span x-text="4 + parseInt(spellLevel)"></span> lightning damage</div>
                    <div x-show="elementType == 'Earth'">Slam: 1d10 + <span x-text="4 + parseInt(spellLevel)"></span> bludgeoning damage</div>
                    <div x-show="elementType == 'Fire'">Slam: 1d10 + <span x-text="4 + parseInt(spellLevel)"></span> fire damage</div>
                    <div x-show="elementType == 'Water'">Slam: 1d10 + <span x-text="4 + parseInt(spellLevel)"></span> cold damage</div>
                </div>
            </td>
        </tr>
    </table>
</div>

</div>
