---
layout:       page
title:        "Elemental Spirit Calculator - D&D Tool"
sub_title:    Elemental Spirit Calculator
description:  Calculates the stats of an Elemental Spirit for the Conjure Elemental spell.
permalink:    /tools/elemental-spirit-calculator
---

<script defer src="https://cdn.jsdelivr.net/npm/alpinejs@3.x.x/dist/cdn.min.js"></script>

<div class="page" x-data="{ edition: 2024, spellLevel: '4', elementType: 'Air' }">

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
                    <option value="4">4</option>
                    <option value="5">5</option>
                    <option value="6">6</option>
                    <option value="7">7</option>
                    <option value="8">8</option>
                    <option value="9">9</option>
                </select>
            </td>
        </tr>
        <tr>
            <td>
                <label for="elementType">Element Type</label>
            </td>
            <td>
                <select id="elementType" x-model="elementType">
                    <option value="Air">Air</option>
                    <option value="Earth">Earth</option>
                    <option value="Fire">Fire</option>
                    <option value="Water">Water</option>
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
            <td x-text="50 + (parseInt(spellLevel) - 4) * 10"></td>
        </tr>
        <tr>
            <td>AC</td>
            <td x-text="11 + parseInt(spellLevel)"></td>
        </tr>
        <tr x-show="elementType == 'Air'">
            <td>Resistances</td>
            <td>Lightning and Thunder</td>
        </tr>
        <tr x-show="elementType == 'Air'">
            <td>Immunities</td>
            <td>Poison, Exhaustion, Paralyzed, Petrified, Poisoned</td>
        </tr>
        <tr x-show="elementType == 'Earth'">
            <td>Resistances</td>
            <td>Piercing and Slashing</td>
        </tr>
        <tr x-show="elementType == 'Earth'">
            <td>Immunities</td>
            <td>Poison, Exhaustion, Paralyzed, Petrified, Poisoned</td>
        </tr>
        <tr x-show="elementType == 'Fire'">
            <td>Immunities</td>
            <td>Poison, Fire, Exhaustion, Paralyzed, Petrified, Poisoned</td>
        </tr>
        <tr x-show="elementType == 'Water'">
            <td>Resistances</td>
            <td>Acid</td>
        </tr>
        <tr x-show="elementType == 'Water'">
            <td>Immunities</td>
            <td>Poison, Exhaustion, Paralyzed, Petrified, Poisoned</td>
        </tr>
        <tr>
            <td># of Attacks</td>
            <td x-text="Math.floor(spellLevel / 2)"></td>
        </tr>
        <tr>
            <td>Slam</td>
            <td>
                <div x-show="edition == '2014'">
                    <div x-show="elementType == 'Air'">1d10 + <span x-text="4 + parseInt(spellLevel)"></span> bludgeoning damage</div>
                    <div x-show="elementType == 'Earth'">1d10 + <span x-text="4 + parseInt(spellLevel)"></span> bludgeoning damage</div>
                    <div x-show="elementType == 'Fire'">1d10 + <span x-text="4 + parseInt(spellLevel)"></span> fire damage</div>
                    <div x-show="elementType == 'Water'">1d10 + <span x-text="4 + parseInt(spellLevel)"></span> bludgeoning damage</div>
                </div>
                <div x-show="edition == '2024'">
                    <div x-show="elementType == 'Air'">1d10 + <span x-text="4 + parseInt(spellLevel)"></span> lightning damage</div>
                    <div x-show="elementType == 'Earth'">1d10 + <span x-text="4 + parseInt(spellLevel)"></span> bludgeoning damage</div>
                    <div x-show="elementType == 'Fire'">1d10 + <span x-text="4 + parseInt(spellLevel)"></span> fire damage</div>
                    <div x-show="elementType == 'Water'">1d10 + <span x-text="4 + parseInt(spellLevel)"></span> cold damage</div>
                </div>
            </td>
        </tr>
    </table>
</div>

</div>
