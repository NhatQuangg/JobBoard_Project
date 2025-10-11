import React from "react";

interface RoleSelectProps {
    value: string;
    onChange: (value: "candidate" | "employer") => void;
}

const RoleSelect = ({ value, onChange }: RoleSelectProps) => (
    <div className="space-y-1">
        <label htmlFor="role" className="text-sm text-gray-900">
            Role
        </label>
        <select
            id="role"
            value={value}
            onChange={(e) =>
                onChange(e.target.value as "candidate" | "employer")
            }
            required
            className="h-12 w-full px-3 bg-white border border-gray-300 text-gray-900 rounded-lg focus:outline-none focus:border-purple-500 focus:ring-1 focus:ring-purple-500"
        >
            <option value="" disabled hidden>
                Select your role
            </option>
            <option value="candidate">Candidate</option>
            <option value="employer">Employer</option>
        </select>
    </div>
);

export default RoleSelect;
