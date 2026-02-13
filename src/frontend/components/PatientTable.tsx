export default function PatientTable() {
  const cellStyle = "border-collapse border border-gray-300 p-4";
  return (
    <div className="flex flex-col gap-4">
      <h1 className="text-2xl font-bold">Patients</h1>
      <table>
        <thead>
          <tr>
            <th className={cellStyle}>FirstName</th>
            <th className={cellStyle}>LastName</th>
            <th className={cellStyle}>PhoneNumber</th>
            <th className={cellStyle}>TenantId</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td className={cellStyle}>Arisa</td>
            <td className={cellStyle}>Audomkhachonkitti</td>
            <td className={cellStyle}>0985734408</td>
            <td className={cellStyle}>Tenant-xxx</td>
          </tr>
        </tbody>
      </table>
    </div>
  );
}
