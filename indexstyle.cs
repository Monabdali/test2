<!--- TESTOTESTO -->

body {
  margin: 0px;
  background: black;
  padding: 0px;
  font-family: 'Arial';
}



h2 {
  text-align: left;
  padding: 20px;
}

/* img container style */
.img-container {
  position: relative;
}

/* Styling for the video */
img {
  width: 100%;
  max-height: 90vh;
  object-fit: cover;
  position: relative;
  z-index: -1;
}

/* Navigation bar styling */
ul {
  list-style-type: none;
  margin: 10px;
  padding: 0;
  position: fixed;
  z-index: 100;
  top: 0;
  left: 0;
  width: 100%;
  background-color: transparent;
  display: flex;
  justify-content: 40px;
  align-items: center;
}

li {
  display: inline;
  left: 30;
  color: white ;
}

ul a {
  display: block;
  padding: 15px;
  color: white;
  text-decoration: none;
  transition: background-color 0.3s, color 0.3s; /* Add a smooth transition for a smoother hover effect */
}

ul a:hover {
  background-color: black;
  border-radius: 30px;
  color: white;
}

ul .active a {
  background-color: #9C8FBA;
  color: white;
}

label {
  text-algin: center;
}


/* Styling for the services section */
#services {
  padding: 0px; /* Adjust the padding as needed */
  text-align: center;
}

.services-buttons {
  display: flex;
  border-radius: 10px;
  justify-content: space-around; /* Center buttons with equal spacing */
  flex-wrap: wrap; /* Allow buttons to wrap to the next line on small screens */
}

.services-buttons button {
  position: relative;
  margin: 5px; /* Adjust the margin to reduce the gap between buttons */
  border: none;
  overflow: hidden;
  flex: 0 0 calc(33.33% - 10px); /* Set a flexible width for each button */
  border-radius: 10px;
  max-width: 500px; /* Set a maximum width for each button */
  background-color: transparent; /* Set background color to transparent */
}

.services-buttons button img {
  width: 450px;
  height: 250px; /* Ensure the image takes up the full height within the button */
  object-fit: cover;
  border-radius: 10px;
  transition: transform 0.3s ease-in-out;
}

.services-buttons button:hover img {
  transform: scale(1.1);
}

.button-text {
  font-size: 20px; /* Adjust the font size for smaller screens */
  font-family: 'Alex Brush', cursive;
  position: absolute;
  top: 25%;
  left: 50%;
  transform: translate(-50%, -50%);
  color: white;
  text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.5);
}

/* Media query for smaller screens */
@media screen and (max-width: 768px) {
  .services-buttons {
    flex-direction: column; /* Display buttons in a column on smaller screens */
    align-items: center; /* Center buttons on smaller screens */
  }
  
  .services-buttons button {
    max-width: 80%; /* Set a smaller width for buttons on smaller screens */
    margin: 3px; /* Adjust the margin for smaller screens */
  }
}

@media (max-width: 768px) {
    .card-container {
        width: 90%; /* Adjust the width for smaller screens */
        max-width: 400px;
        top: 50px; /* Set a top margin to avoid overlapping with navigation buttons */
    }
}



/* Footer styling */
footer { 
  color: black;
  padding: 20px;
}

.social-icons {
  display: flex;
  justify-content: left;
  z-index: 1;
}

.social-icons a {
  margin: 0 10px; /* Adjust the spacing between icons as needed */
}

.social-icons img {
  width: 40px; /* Adjust the icon size as needed */
}

