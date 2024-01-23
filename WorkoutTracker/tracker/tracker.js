// declare storedSubmissions globally
let storedSubmissions = JSON.parse(sessionStorage.getItem("submissions")) || {};

document.addEventListener("DOMContentLoaded", function () {
    //create variables for html elements
    const calendar = document.getElementById("calendar");
    const entryResults = document.getElementById("entry-results");
    const calendarEntryForm = document.getElementById("calendar-entry-form");

    //generate the calendar
    function generateCalendar(givenDate) {
        //clear existing calendar
        calendar.textContent = "";

        //get current date
        const currentDate = givenDate || new Date();
        const currentYear = currentDate.getFullYear();
        const currentMonth = currentDate.getMonth();
        //get number of days in current month. passing the next month of current date along with 0 as a parameter for days returns the last
        //      day of previous month (so current month's last day)
        const daysOfMonth = new Date(currentYear, currentMonth + 1, 0).getDate();

        //create table caption with name of month and nav buttons
        const caption = document.createElement("caption");
        const previousButton = document.createElement("button");
        previousButton.textContent = "Previous";
        previousButton.addEventListener("click", () => {
        //move to previous month and regenerate calendar 
            currentDate.setMonth(currentDate.getMonth() - 1);
            generateCalendar(currentDate);
        });

        const nextButton = document.createElement("button");
        nextButton.textContent = "Next";
        nextButton.addEventListener("click", () => {
            //move to next month and regenerate calendar 
            currentDate.setMonth(currentDate.getMonth() + 1);
            generateCalendar(currentDate);
        });

        //append elements to caption and output name of month and year
        caption.appendChild(previousButton);
        caption.appendChild(document.createTextNode(` ${getMonthName(currentMonth)} ${currentYear} `));
        caption.appendChild(nextButton);

        //append caption to calendar
        calendar.appendChild(caption);

        //create calendar header row for days of week
        const headerRow = document.createElement("tr");
        for (let i = 0; i < 7; i++) {
            //create table headings for days of week
            const dayOfWeek = document.createElement("th");
            //get the name of day and add to name of day header row
            dayOfWeek.textContent = getDayName(i);
            headerRow.appendChild(dayOfWeek);
        }
        //add names of week header row to calendar form
        calendar.appendChild(headerRow);

        //create calendar days
        let dayNumber = 1;
        const firstDayOfMonth = new Date(currentYear, currentMonth, 1).getDay();

        for (let week = 0; week < 6; week++) {
            const calendarRow = document.createElement("tr");
            for (let day = 0; day < 7; day++) {
                const calendarCell = document.createElement("td");

                // make sure first day number correlates to the correct day name heading if its the first week
                //once week is greater than 0, make sure number of dayNumber isn't greater than number of days in month
                if ((week === 0 && day >= firstDayOfMonth) || (week > 0 && dayNumber <= daysOfMonth)) {
                    calendarCell.textContent = dayNumber;

                    // Construct the dateKey in the format "MM/DD/YYYY"
                    //dateKey will be used as unique key for user data entries
                    const monthForFormat = currentMonth + 1;
                    const formattedMonth = (monthForFormat < 10) ? `0${monthForFormat}` : monthForFormat.toString();
                    const formattedDay = (dayNumber < 10) ? `0${dayNumber}` : dayNumber.toString();
                    const dateKey = `${formattedMonth}/${formattedDay}/${currentYear}`;

                    //create click handler for each day to retrieve data of that day on cellclick (js closure)
                    calendarCell.addEventListener("click", function () {
                        handleDayClick(dateKey);
                    });

                    
                    //if any cell date matches a property in storedsubmissions, change background color of cell
                    if (storedSubmissions[dateKey]) {
                        calendarCell.style.backgroundColor = "#90EE90";
                    }

                    dayNumber++;
                }
                calendarRow.appendChild(calendarCell);
            }
            calendar.appendChild(calendarRow);
        }
    }

    function getDayName(dayIndex) {
        const daysOfWeek = [
            "Sun.",
            "Mon.",
            "Tues.",
            "Wed.",
            "Thurs.",
            "Fri.",
            "Sat.",
        ];
        return daysOfWeek[dayIndex];
    }

    function getMonthName(monthIndex) {
        const months = [
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December",
        ];
        return months[monthIndex];
    }

    //function for deleting user submissions from sessionStorage
    function deleteSubmissionEntry(dateKey, index) {
        //remove the submission at the specified index
        storedSubmissions = JSON.parse(sessionStorage.getItem("submissions")) || {};

        //check if there are submissions for the given date
        if (storedSubmissions[dateKey]) {
            //remove the submission at the specified index
            storedSubmissions[dateKey].splice(index, 1);
            //update sessionStorage
            localStosessionStoragerage.setItem("submissions", JSON.stringify(storedSubmissions));

          
            //check if the array is empty
            if (storedSubmissions[dateKey].length === 0) {
                //if empty, delete the property from storedSubmissions
                delete storedSubmissions[dateKey];

                //update sessionStorage again to reflect the property removal
                sessionStorage.setItem("submissions", JSON.stringify(storedSubmissions));   
            }
            //refresh the display
            generateCalendar(new Date());
            handleDayClick(dateKey);
        }
    }


    function handleDayClick(dateKey) {

        storedSubmissions = JSON.parse(sessionStorage.getItem("submissions"));
        const entryResultsDateTitle = document.getElementById('entry-results-date-title');

        //check if there are submissions for the given date
        if (storedSubmissions[dateKey]) {
            let submissionsHTML = ''; //initialize an empty string

            //iterate over each submission and append HTML to submissionsHTML
            storedSubmissions[dateKey].forEach((submission, index) => {
                submissionsHTML += `
                    <div class="entry">
                        <div class="entry-content">
                            <h3>Type: </h3>
                            <p>${submission.type}</p>
                            <h3>Title: </h3>
                            <p>${submission.title}</p>
                            <h3>Description:</h3>
                            <p>${submission.description}</p>
                            <h3>Recommend: </h3>
                            <p>${submission.recommend}</p>
                        </div>
                        <button class="delete-button" data-datekey="${dateKey}" data-index="${index}">Delete Entry</button>
                    </div>
                `;
            });

            //update entryResults div and h3 title with stored data
            entryResultsDateTitle.innerHTML = dateKey;
            entryResultsDateTitle.style.display = "block";
            entryResults.innerHTML = submissionsHTML;
        }  
        else {
            //update entryResults div if there are no submissions for the date
            entryResultsDateTitle.innerHTML = dateKey;
            entryResultsDateTitle.style.display = "block";
            entryResults.innerHTML = `
                <div class="no-entry-content">
                    <p>No submissions for this date.</p>
                </div>
            `;
        }
    }

    function handleFormSubmission(event) {
        event.preventDefault();
        //get inputs from form
        const dateInput = document.getElementById("date-input");
        const typeInput = document.getElementById("entry-type");
        const titleInput = document.getElementById("entry-title");
        const descriptionInput = document.getElementById("entry-description");
        const recommendInput = document.getElementById("yes-recommend");

        
        //create object with form data to store in sessionStorage
        //the user inputted date will be the unique key 

        const formDate = dateInput.value;
        //check if object exists for the date otherwise initialize empty array
        if (!storedSubmissions[formDate]) {
            storedSubmissions[formDate] = [];
        }
        //add new values to array under date property in sessionStorage storedSubmission's object
        storedSubmissions[formDate].push ({
            type: typeInput.value,
            title: titleInput.value,
            description: descriptionInput.value,
            recommend: recommendInput.checked ? "Yes" : "No",
        });

        sessionStorage.setItem("submissions", JSON.stringify(storedSubmissions));

        //refresh the calendar and clear form data
        generateCalendar(new Date());
        document.getElementById('calendar-entry-form').reset();
    }
    

    //add an event listener for the delete button using delegation
    document.addEventListener('click', function(event) {

        //check if the clicked element has the "delete-button" class
        if (event.target.classList.contains('delete-button')) {

            //extract the dateKey and index from the data attributes
            const dateKey = event.target.getAttribute('data-datekey');
            const index = parseInt(event.target.getAttribute('data-index'));

            //call the deleteSubmission function
            deleteSubmissionEntry(dateKey, index);
        }
    });

    //attach form submission handler to the form
    const form = document.getElementById("calendar-entry-form");
    form.addEventListener("submit", handleFormSubmission);

    //invoke generateCalendar on page load
    generateCalendar(new Date());
});

