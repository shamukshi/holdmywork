<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <title>HoldMyWork | Welcome</title>

    <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        body {
            font-family: "Segoe UI", Arial, sans-serif;
            background: #0f172a;
            color: white;
            min-height: 100vh;
            overflow-x: hidden;
        }

        /* Background decorations */
        body::before {
            content: "";
            position: fixed;
            width: 500px;
            height: 500px;
            background: #7c3aed;
            border-radius: 50%;
            filter: blur(180px);
            opacity: 0.35;
            top: -200px;
            left: -150px;
            z-index: -1;
        }

        body::after {
            content: "";
            position: fixed;
            width: 450px;
            height: 450px;
            background: #06b6d4;
            border-radius: 50%;
            filter: blur(180px);
            opacity: 0.25;
            bottom: -200px;
            right: -100px;
            z-index: -1;
        }

        /* Navigation */
        nav {
            width: 90%;
            max-width: 1150px;
            margin: auto;
            padding: 28px 0;
            display: flex;
            justify-content: space-between;
            align-items: center;
        }

        .logo {
            font-size: 28px;
            font-weight: 800;
            letter-spacing: -1px;
        }

        .logo span {
            color: #a78bfa;
        }

        .status {
            background: rgba(255,255,255,0.08);
            border: 1px solid rgba(255,255,255,0.15);
            padding: 10px 18px;
            border-radius: 30px;
            font-size: 14px;
            color: #c4b5fd;
        }

        /* Main hero */
        .hero {
            width: 90%;
            max-width: 1100px;
            margin: 70px auto 0;
            text-align: center;
        }

        .badge {
            display: inline-block;
            padding: 8px 18px;
            border-radius: 30px;
            background: rgba(139,92,246,0.15);
            border: 1px solid rgba(167,139,250,0.4);
            color: #c4b5fd;
            font-size: 14px;
            margin-bottom: 25px;
        }

        h1 {
            font-size: clamp(42px, 7vw, 82px);
            line-height: 1.1;
            font-weight: 800;
            letter-spacing: -3px;
        }

        h1 span {
            background: linear-gradient(
                90deg,
                #a78bfa,
                #38bdf8,
                #2dd4bf
            );
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
        }

        .subtitle {
            max-width: 650px;
            margin: 25px auto;
            font-size: 19px;
            line-height: 1.7;
            color: #cbd5e1;
        }

        /* Download button */
        .download-btn {
            display: inline-flex;
            align-items: center;
            gap: 12px;
            margin-top: 25px;
            padding: 18px 36px;
            border-radius: 14px;
            text-decoration: none;
            color: white;
            font-size: 18px;
            font-weight: 700;
            background: linear-gradient(
                135deg,
                #7c3aed,
                #2563eb
            );
            box-shadow: 0 12px 35px rgba(99,102,241,0.35);
            transition: all 0.3s ease;
        }

        .download-btn:hover {
            transform: translateY(-5px);
            box-shadow: 0 18px 45px rgba(99,102,241,0.55);
        }

        .download-icon {
            font-size: 25px;
        }

        .file-info {
            margin-top: 15px;
            color: #94a3b8;
            font-size: 13px;
        }

        /* Feature cards */
        .features {
            width: 90%;
            max-width: 1050px;
            margin: 85px auto;
            display: grid;
            grid-template-columns: repeat(3, 1fr);
            gap: 22px;
        }

        .card {
            padding: 32px 25px;
            text-align: center;
            border-radius: 20px;
            background: rgba(255,255,255,0.06);
            border: 1px solid rgba(255,255,255,0.12);
            backdrop-filter: blur(15px);
            transition: transform 0.3s ease,
                        background 0.3s ease;
        }

        .card:hover {
            transform: translateY(-8px);
            background: rgba(255,255,255,0.11);
        }

        .card-icon {
            font-size: 40px;
            margin-bottom: 18px;
        }

        .card h3 {
            font-size: 21px;
            margin-bottom: 12px;
        }

        .card p {
            color: #94a3b8;
            line-height: 1.6;
            font-size: 15px;
        }

        /* Bottom message */
        .message {
            text-align: center;
            margin: 40px auto 80px;
        }

        .message h2 {
            font-size: 30px;
            margin-bottom: 12px;
        }

        .message p {
            color: #94a3b8;
        }

        /* Footer */
        footer {
            text-align: center;
            padding: 28px;
            border-top: 1px solid rgba(255,255,255,0.1);
            color: #64748b;
            font-size: 14px;
        }

        /* Responsive design */
        @media (max-width: 700px) {
            nav {
                padding: 20px 0;
            }

            .logo {
                font-size: 23px;
            }

            .status {
                font-size: 12px;
                padding: 8px 12px;
            }

            .hero {
                margin-top: 45px;
            }

            h1 {
                letter-spacing: -1px;
            }

            .subtitle {
                font-size: 16px;
            }

            .features {
                grid-template-columns: 1fr;
                margin-top: 60px;
            }

            .download-btn {
                padding: 16px 25px;
                font-size: 16px;
            }
        }
    </style>
</head>

<body>

    <!-- Navigation -->
    <nav>
        <div class="logo">
            Hold<span>My</span>Work
        </div>

        <div class="status">
            ✦ Simple. Useful. Reliable.
        </div>
    </nav>

    <!-- Hero section -->
    <section class="hero">

        <div class="badge">
            🚀 Welcome to HoldMyWork
        </div>

        <h1>
            Work smarter.<br>
            <span>Not harder.</span>
        </h1>

        <p class="subtitle">
            A simple tool designed to make your everyday work
            easier, faster, and more efficient.
            Get started today and experience the difference.
        </p>

        <!-- DOWNLOAD BUTTON -->
        <a
            class="download-btn"
            href="https://github.com/shamukshi/holdmywork/raw/refs/heads/main/FormApp.cs"
            download="FormApp.cs"
        >
            <span class="download-icon">⬇</span>
            Download HoldMyWork
        </a>

        <div class="file-info">
            FormApp.cs &nbsp;•&nbsp; Latest Version
        </div>

    </section>

    <!-- Features -->
    <section class="features">

        <div class="card">
            <div class="card-icon">⚡</div>
            <h3>Fast</h3>
            <p>
                Save time and simplify repetitive tasks
                with a lightweight and efficient tool.
            </p>
        </div>

        <div class="card">
            <div class="card-icon">🛠️</div>
            <h3>Useful</h3>
            <p>
                Built to help you work more efficiently
                and focus on what matters.
            </p>
        </div>

        <div class="card">
            <div class="card-icon">🔒</div>
            <h3>Reliable</h3>
            <p>
                Designed with simplicity and reliability
                in mind for your everyday workflow.
            </p>
        </div>

    </section>

    <!-- Closing message -->
    <section class="message">
        <h2>Make every task count. ✨</h2>
        <p>
            Less effort. More productivity. Better results.
        </p>
    </section>

    <!-- Footer -->
    <footer>
        © 2026 HoldMyWork. All rights reserved.
        <br><br>
        Made with ❤️ for productive people.
    </footer>

</body>
</html>
