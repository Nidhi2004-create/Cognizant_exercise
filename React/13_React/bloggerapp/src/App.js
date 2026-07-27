import React from 'react';
import './App.css';
import { 
  BookDetails, 
  BlogDetails, 
  CourseDetails, 
  books, 
  courses, 
  blogs 
} from './components';

function App() {
  // Using Element Variables for Conditional Rendering
  const bookdet = <BookDetails books={books} />;
  const coursedet = <CourseDetails courses={courses} />;
  const content = <BlogDetails blogs={blogs} />;

  return (
    <div className="container">
      <div className="mystyle1">
        <h1>Course Details</h1>
        {coursedet}
      </div>

      <div className="v1">
        <h1>Book Details</h1>
        {bookdet}
      </div>

      <div className="st2">
        <h1>Blog Details</h1>
        {content}
      </div>
    </div>
  );
}

export default App;