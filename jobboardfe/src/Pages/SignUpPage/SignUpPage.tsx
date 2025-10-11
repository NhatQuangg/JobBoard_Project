import React, { useState } from "react";
import { Link } from "react-router-dom";
import InputField from "../../Components/InputField/InputField";
import PasswordInput from "../../Components/PasswordInput/PasswordInput";
import AuthHeader from "../../Components/AuthHeader/AuthHeader";
import GoogleButton from "../../Components/GoogleButton/GoogleButton";
import RoleSelect from "../../Components/SignUp/RoleSelect/RoleSelect";
import PasswordCriteria from "../../Components/SignUp/PasswordCriteria/PasswordCriteria";

const SignUpPage = () => {
    const [email, setEmail] = useState("");
    const [step, setStep] = useState<"email" | "details">("email");
    const [name, setName] = useState("");
    const [password, setPassword] = useState("");
    const [role, setRole] = useState<"" | "candidate" | "employer">("");
    const [companyName, setCompanyName] = useState("");
    const [isActive, setIsActive] = useState(true);
    const [showPassword, setShowPassword] = useState(false);

    // Password validation
    const passwordMinLength = password.length >= 8;
    const passwordHasUpper = /[A-Z]/.test(password);
    const passwordHasLower = /[a-z]/.test(password);
    const passwordHasNumber = /[0-9]/.test(password);
    const passwordValid =
        passwordMinLength &&
        passwordHasUpper &&
        passwordHasLower &&
        passwordHasNumber;

    const handleGoogleSignup = () => {
        console.log("Google signup clicked");
    };

    const handleEmailSignup = (e: React.FormEvent) => {
        e.preventDefault();
        if (!email || !role) return;
        console.log("Continue with email:", email, "Role:", role);
        setStep("details");
    };

    const handleDetailsSubmit = (e: React.FormEvent) => {
        e.preventDefault();
        if (!name || !password) return;

        const user: any = {
            Email: email,
            Password: password,
            FullName: name,
            Role: role,
            CreatedAt: new Date().toISOString(),
            IsActive: isActive,
        };

        if (role === "employer") user.CompanyName = companyName;

        console.log("Signup data:", user);
    };

    return (
        <div className="min-h-screen flex items-center justify-center bg-white px-4">
            <div className="w-full max-w-md space-y-8">
                <AuthHeader title="Create your free account" />

                {step === "email" ? (
                    <form onSubmit={handleEmailSignup} className="space-y-3">
                        <GoogleButton onClick={handleGoogleSignup} />

                        {/* Divider */}
                        <div className="relative">
                            <div className="absolute inset-0 flex items-center">
                                <div className="w-full border-t border-gray-300" />
                            </div>
                            <div className="relative flex justify-center text-sm">
                                <span className="px-2 bg-white text-gray-500">
                                    or
                                </span>
                            </div>
                        </div>

                        <InputField
                            id="email"
                            label="Email Address"
                            type="email"
                            placeholder="jane@example.com"
                            value={email}
                            onChange={(e) => setEmail(e.target.value)}
                            required
                        />

                        <RoleSelect value={role} onChange={setRole} />

                        <button
                            type="submit"
                            className="w-full h-12 bg-gradient-to-r from-purple-600 to-purple-700 hover:from-purple-700 hover:to-purple-800 text-white rounded-lg font-medium"
                        >
                            Continue
                        </button>
                    </form>
                ) : (
                    <form onSubmit={handleDetailsSubmit} className="space-y-6">
                        <div className="space-y-3">
                            <InputField
                                id="name"
                                label="Full Name"
                                placeholder="Jane Doe"
                                value={name}
                                onChange={(e) => setName(e.target.value)}
                                required
                            />

                            {role === "employer" && (
                                <InputField
                                    id="company"
                                    label="Company Name"
                                    placeholder="Your company name"
                                    value={companyName}
                                    onChange={(e) =>
                                        setCompanyName(e.target.value)
                                    }
                                    required
                                />
                            )}

                            <PasswordInput
                                value={password}
                                onChange={(e) => setPassword(e.target.value)}
                                showPassword={showPassword}
                                toggleShow={() => setShowPassword((s) => !s)}
                            />

                            <ul className="mt-1 ml-3 text-sm text-gray-600">
                                <PasswordCriteria password={password} />
                            </ul>
                        </div>

                        {/* Buttons */}
                        <div className="flex gap-2">
                            <button
                                type="button"
                                onClick={() => setStep("email")}
                                className="flex-1 h-12 border border-gray-300 text-gray-700 rounded-lg"
                            >
                                Back
                            </button>
                            <button
                                type="submit"
                                disabled={!passwordValid}
                                className={`flex-1 h-12 ${
                                    passwordValid
                                        ? "bg-gradient-to-r from-purple-600 to-purple-700 text-white"
                                        : "bg-gray-200 text-gray-400 cursor-not-allowed"
                                } font-medium rounded-lg`}
                            >
                                Create account
                            </button>
                        </div>
                    </form>
                )}

                <p className="text-center text-gray-700 text-sm">
                    Already have an account?{" "}
                    <Link
                        to="/login"
                        className="text-purple-700 hover:text-purple-800 font-medium"
                    >
                        Log in
                    </Link>
                </p>
            </div>
        </div>
    );
};

export default SignUpPage;
