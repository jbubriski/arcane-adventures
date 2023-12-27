var diceRoller = {};
diceRoller.log = [];

(function () {
    var elements = document.getElementsByClassName('dice-roll');

    for (var i = 0; i < elements.length; i++) {
        log('Attaching:', elements[i]);

        elements[i].addEventListener('mousedown', function(e) { rollDice(this, e); })
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

        var result = calculateDiceRoll(element.dataset.roll);

        if (advantage || disadvantage) {
            var result2 = calculateDiceRoll(element.dataset.roll);
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
        }

        diceRoller.log.push(rollData);

        showToast(rollData);
    }

    function calculateDiceRoll(rollText) {
        var rolls = [];
        var adds = [];
        var totalValue = 0;

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

        return {
            rolls: rolls,
            adds: adds,
            totalValue: totalValue
        };
    }

    function showToast(rollData) {
        log(rollData);

        var snackbar = document.getElementById("snackbar");

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

        newMessageRow.append(rollTypeColumn);
        newMessageRow.append(rollColumn);

        snackbar.append(newMessageRow);
        snackbar.className = "show";

        setTimeout(function () {
            tryCloseToast(newMessageRow);
        }, 10000);
    }

    function tryCloseToast(messageDiv) {
        messageDiv.remove();

        var snackbar = document.getElementById("snackbar");

        if (snackbar.childNodes.length === 0) {
            snackbar.className = snackbar.className.replace("show", "hide");
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
