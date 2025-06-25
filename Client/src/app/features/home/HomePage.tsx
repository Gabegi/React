import React from "react";

export default function HomePage() {
  return (
    <div
      style={{
        position: "relative",
        width: "100vw",
        height: "100vh",
        minHeight: "100vh",
        backgroundImage: "url('/public/images/vineyard.png')", // Replace this URL as needed
        backgroundSize: "cover",
        backgroundPosition: "center",
        display: "flex",
        alignItems: "center",
        justifyContent: "center",
        overflow: "hidden",
      }}
    >
      <div
        style={{
          background: "rgba(255,255,255,0.7)",
          padding: "2rem 3rem",
          borderRadius: "12px",
          boxShadow: "0 4px 24px rgba(0,0,0,0.15)",
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
            margin: 0,
          }}
        >
          Welcome to Crimson Wines, where passion blends into wine
        </h1>
      </div>
    </div>
  );
}
