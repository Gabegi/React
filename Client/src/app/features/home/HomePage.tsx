import React from "react";

export default function HomePage() {
  return (
    <div
      style={{
        display: "flex",
        flexDirection: "column",
        alignItems: "center",
        justifyContent: "center",
        minHeight: "60vh",
        textAlign: "center",
      }}
    >
      <h1
        style={{
          fontFamily: "'Playfair Display', serif",
          fontStyle: "italic",
          fontSize: "1.5rem",
          fontWeight: 400,
          letterSpacing: "0.03em",
        }}
      >
        Welcome to Crimson Wines, where passion blends into wine
      </h1>
      <img
        src="/public/images/your-image.png" // Replace this URL as needed
        alt="Crimson Wines"
        style={{
          marginTop: "2rem",
          maxWidth: "400px",
          width: "100%",
          borderRadius: "8px",
        }}
      />
    </div>
  );
}
