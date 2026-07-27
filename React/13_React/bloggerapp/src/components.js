import React from 'react';

// Sample Data
export const books = [
  { id: 101, bname: 'Master React', price: 670 },
  { id: 102, bname: 'Deep Dive into Angular 11', price: 800 },
  { id: 103, bname: 'Mongo Essentials', price: 450 }
];

export const courses = [
  { id: 201, cname: 'Angular', date: '4/5/2021' },
  { id: 202, cname: 'React', date: '6/3/2021' }
];

export const blogs = [
  { id: 301, title: 'React Learning', author: 'Stephen Biz', desc: 'Welcome to learning React!' },
  { id: 302, title: 'Installation', author: 'Schewzdenier', desc: 'You can install React from npm.' }
];

// 1. Course Details Component
export function CourseDetails(props) {
  return (
    <div>
      {props.courses.map((course) => (
        <div key={course.id} style={{ marginBottom: '15px' }}>
          <h2>{course.cname}</h2>
          <p><b>{course.date}</b></p>
        </div>
      ))}
    </div>
  );
}

// 2. Book Details Component
export function BookDetails(props) {
  return (
    <ul style={{ listStyleType: 'none', padding: 0 }}>
      {props.books.map((book) => (
        <div key={book.id} style={{ marginBottom: '15px' }}>
          <h3>{book.bname}</h3>
          <h4>{book.price}</h4>
        </div>
      ))}
    </ul>
  );
}

// 3. Blog Details Component
export function BlogDetails(props) {
  return (
    <div>
      {props.blogs.map((blog) => (
        <div key={blog.id} style={{ marginBottom: '15px' }}>
          <h2>{blog.title}</h2>
          <p><b>{blog.author}</b></p>
          <p>{blog.desc}</p>
        </div>
      ))}
    </div>
  );
}