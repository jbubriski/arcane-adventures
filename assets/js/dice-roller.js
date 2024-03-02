var diceRoller = {};
diceRoller.log = [];

(function () {
    var diceRollElements = document.getElementsByClassName("dice-roll");
    var autoRollerElements = document.getElementsByClassName("js-auto-roller");

    for (var i = 0; i < diceRollElements.length; i++) {
        log("Attaching:", diceRollElements[i]);

        diceRollElements[i].addEventListener("mousedown", function (e) {
            rollDice(this, e);
        });
    }

    for (var i = 0; i < autoRollerElements.length; i++) {
        log("Attaching auto roller:", autoRollerElements[i]);

        autoRollerElements[i].addEventListener("mousedown", function (e) {
            autoRollDice(this, e);
        });
    }


    function rollDice(element, e) {
        e.preventDefault();

        log('Rolling:', element);

        var roll = element.dataset.roll;
        var isAttackRoll = element.dataset.isAttackRoll;
        var rollType = element.dataset.rollType;

        var advantage = element.dataset.advantage;
        var disadvantage = element.dataset.disadvantage;

        var isCriticalHit = false;

        var result = calculateDiceRoll(element.dataset.roll, element);

        if (advantage || disadvantage) {
            var result2 = calculateDiceRoll(element.dataset.roll, element);
        }

        log(result);

        if (isAttackRoll && result.rolls[0].roll == 20) {
            isCriticalHit = true;
        }

        var rollsStrings = result.rolls.map((x) => x.roll);
        var rollResultParts = rollsStrings.concat(result.adds);
        var message = rollResultParts.length > 1
            ? `${rollResultParts.join(' + ')} = ${result.totalValue}`
            : result.totalValue;

        var rollData = {
            roll: roll,
            isAttackRoll: isAttackRoll,
            rollType: rollType,
            message: message,
            result: result.totalValue,
            rollValueText: result.rollValueText,
            isCriticalHit: isCriticalHit
        };

        if (advantage || disadvantage) {
            var rollsStrings2 = result2.rolls.map((x) => x.roll);
            var rollResultParts2 = rollsStrings2.concat(result2.adds);
            var message2 = rollResultParts2.length > 1
                ? `${rollResultParts2.join(' + ')} = ${result2.totalValue}`
                : result2.totalValue;

            if (advantage) {
                var higherRollResult = result.totalValue > result2.totalValue ? result.totalValue : result2.totalValue;
            } else {
                var higherRollResult = result.totalValue < result2.totalValue ? result.totalValue : result2.totalValue;
            }

            rollData.rollType += advantage ? " with advantage" : " with disadvantage";
            rollData.message = `(${message}, ${message2}) = ${higherRollResult}`
            rollData.result2 = result2.totalValue;
            rollData.rollValueText = result2.rollValueText
        }

        diceRoller.log.push(rollData);

        showToast(rollData);
    }

    function autoRollDice(element, e) {
        e.preventDefault();

        log("Rolling:", element);

        // Roll each one separately
        for (var i = 0; i < diceRollElements.length; i++) {
            rollDice(diceRollElements[i], e);
        }
    }

    function calculateDiceRoll(rollText, element) {
        var rolls = [];
        var adds = [];
        var totalValue = 0;
        var rollValueText = '';

        log(rollText);

        var rollParts = rollText.split('+');

        log(rollParts);

        for (var j = 0; j < rollParts.length; j++) {
            var rollPart = rollParts[j].trim();

            log('Part: ' + rollPart);

            if (!isNaN(rollPart)) {
                console.log('Adding ' + rollPart);

                adds.push(+rollPart);

                totalValue += +rollPart;
                continue;
            }

            var rollParts2 = rollParts[j].trim().split('d');
            var numberOfDice = rollParts2[0].trim();
            var dieNumber = rollParts2[1].trim();

            for (var k = 0; k < numberOfDice; k++) {
                var roll = Math.ceil(Math.random() * dieNumber);

                totalValue += roll;

                rolls.push({
                    dieNumber: dieNumber,
                    roll: roll
                });

                console.log(rolls);
            }
            console.log(rollParts2);
        }

        log("Total value:", totalValue);

        var parent = element.parentNode.parentNode.parentNode.parentNode.parentNode;

        if (parent && parent.classList && parent.classList.contains("js-roll-table")) {
            log("Roll table");

            var rollTable = parent.querySelector("table");

            if (rollTable) {
                rollValueText = rollTable.rows[totalValue].cells[1].innerText;

                log("Roll value text:", rollValueText);
            }
        }

        return {
            rolls: rolls,
            adds: adds,
            totalValue: totalValue,
            rollValueText: rollValueText
        };
    }

    function showToast(rollData) {
        log(rollData);

        var dicetray = document.getElementById("dicetray");

        var newMessageRow = document.createElement("div");
        newMessageRow.className = 'roll-row';

        if (rollData.isCriticalHit) {
            newMessageRow.className += " critical-hit";
        }

        var rollTypeColumn = document.createElement("div");
        rollTypeColumn.className = 'roll-column';
        rollTypeColumn.innerHTML = rollData.rollType + "<br />" + rollData.roll;

        var rollColumn = document.createElement("div");
        rollColumn.className = 'roll-column';
        rollColumn.innerText = rollData.message;

        var rollColumn2 = document.createElement("div");
        rollColumn2.className = "roll-column";
        rollColumn2.innerText = rollData.rollValueText;

        newMessageRow.append(rollTypeColumn);
        newMessageRow.append(rollColumn);
        newMessageRow.append(rollColumn2);

        dicetray.append(newMessageRow);
        dicetray.className = "show";

        setTimeout(function () {
            tryCloseToast(newMessageRow);
        }, 10000);
    }

    function tryCloseToast(messageDiv) {
        messageDiv.remove();

        var dicetray = document.getElementById("dicetray");

        if (dicetray.childNodes.length === 0) {
            dicetray.className = dicetray.className.replace("show", "hide");
        }
    }

    function log(message, message2) {
        if (message2) {
            console.log(message, message2);
        } else {
            console.log(message)
        }
    }

    diceRoller.showLog = function() {

    }
})();
