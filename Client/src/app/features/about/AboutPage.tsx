import React from "react";

export default function AboutPage() {
  return (
    <div
      style={{
        position: "relative",
        width: "100vw",
        height: "100vh",
        minHeight: "100vh",
        backgroundImage: "url('/public/images/vineyard.png')", // Replace this URL as needed
        backgroundSize: "80%",
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
          Crimson Wines is a family-owned winery located in the heart of the
          Provence.
          <br />
          We are passionate about wine and we are committed to offering you the
          best wines.
          <br />
          We are located in the heart of the Provence, in the village of
          Cairanne.
          <br />
          We are open from Monday to Saturday from 10am to 6pm.
        </h1>
      </div>
    </div>
  );
}
