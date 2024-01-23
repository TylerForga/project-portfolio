document.addEventListener("DOMContentLoaded", function () {

    const workoutImages = document.querySelectorAll(".picture-column-left a");
    const foodImages =  document.querySelectorAll(".picture-column-right a");

    console.log(workoutImages);
    console.log(foodImages);
    
    let currentIndex = 0;
  
    function showFoodImage(index) {
      foodImages.forEach((foodImage, i) => {
        foodImage.style.display = i === index ? "block" : "none";
      });
    }
  
    function nextFoodImage() {
      currentIndex = (currentIndex + 1) % foodImages.length;
      showFoodImage(currentIndex);
    }

    function showWorkoutImage(index) {
      workoutImages.forEach((workoutImage, i) => {
        workoutImage.style.display = i === index ? "block" : "none";
      });
    }
  
    function nextWorkoutImage() {
      currentIndex = (currentIndex + 1) % workoutImages.length;
      showWorkoutImage(currentIndex);
    }
  
  
    function checkScreenSize(){
      const isSmallScreen = window.innerWidth <= 940;
    
      if (isSmallScreen) {
        showFoodImage(currentIndex);
        showWorkoutImage(currentIndex);
        setInterval(nextFoodImage, 5000);
        setInterval(nextWorkoutImage, 5000);
      }
    }
    
    //checkScreenSize();

    window.addEventListener("resize", checkScreenSize());


  });
